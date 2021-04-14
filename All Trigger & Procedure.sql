------------------------------------ T R I G G E R --------------------------------------------------------
	-- set managerNIK to null when manager is deleted
	CREATE OR ALTER TRIGGER [dbo].[T_DeleteManager] ON [dbo].[TB_M_Account]
	INSTEAD OF DELETE AS
	BEGIN
		DECLARE @nik nvarchar(450) = (SELECT NIK from deleted)
		IF EXISTS (SELECT * FROM TB_M_Employee WHERE NIK = @nik)
		BEGIN
			UPDATE TB_M_Employee
			SET ManagerNIK = NULL
			WHERE ManagerNIK = @nik

			DELETE FROM TB_M_Account WHERE NIK = @nik
		END
		ELSE
			DELETE FROM TB_M_Account WHERE NIK = @nik
	END
	GO
	
	--set status manager to pending when compensationrequest is inserted
	CREATE OR ALTER TRIGGER [dbo].[T_CompensationRequest] ON [dbo].[TB_T_CompensationRequest]
	AFTER INSERT AS
	BEGIN
		DECLARE @StatusID INT
		DECLARE @NIK nvarchar(450)
		DECLARE @DepartmentID INT 
		SET @StatusID = (SELECT StatusID FROM TB_M_Status WHERE StatusName LIKE '%Pending%') 
		SET @NIK = (SELECT ManagerNIK FROM TB_M_Employee WHERE NIK = (SELECT NIK FROM inserted))
		SET @DepartmentID = (SELECT dep.DepartmentID FROM TB_M_Department dep JOIN TB_M_Position pos ON dep.DepartmentID = pos.DepartmentID JOIN TB_M_Employee emp ON pos.PositionID = emp.PositionID WHERE emp.NIK = @NIK)

		INSERT INTO TB_T_Approval
		SELECT @StatusID,@NIK,RequestID,@DepartmentID,GETDATE(),NULL
		FROM INSERTED
	END
	GO

---------------------------------------- P R O C E D U R E -----------------------------------------------
	-- Delete all accountrole by id --
	CREATE OR ALTER PROCEDURE [dbo].[SP_DeleteAccountRoleByID]
	@nik nvarchar(450)
	AS
	BEGIN
		DELETE FROM TB_T_AccountRole WHERE NIK = @nik
	END
	GO

	-- get all accountrole by id --
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveAccountRoleByID]
	@nik nvarchar(450)
	AS
	BEGIN
		SELECT * FROM TB_T_AccountRole
		WHERE NIK = @nik
	END
	GO

	-- Get phone & email for validation --
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveValidation]
		@Params varchar(max)
	AS
	BEGIN
		SELECT * FROM TB_M_Employee WHERE Email = @Params OR Phone = @Params
	END
	GO

	-- Get Compensation for Chart -- 
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveChart]
	@Params nvarchar(max)
	AS
	BEGIN
		SELECT COUNT(@Params) AS Request, YEAR(RequestDate) AS [Year]
		FROM TB_T_CompensationRequest GROUP BY YEAR(RequestDate)
		ORDER BY YEAR(RequestDate)
	END
	GO
	
	--get email manager --
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveManagerEmail]
		@departmentID int
	AS
	BEGIN
		SELECT Email from TB_M_Employee 
		JOIN TB_M_Position 
		ON TB_M_Employee.PositionID = TB_M_Position.PositionID
		JOIN TB_M_Department
		ON TB_M_Position.DepartmentID = TB_M_Department.DepartmentID
		WHERE PositionName = 'RM' AND TB_M_Department.DepartmentID = @departmentID
	END
	GO

	-- Get Request List --
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveRequestList]
		@Status nvarchar(max),
		@DepartmentName nvarchar(max)
	AS
	BEGIN
	SELECT creq.RequestID, emp.EmployeeName, emp.JoinDate, (SELECT EmployeeName FROM TB_M_Employee WHERE NIK = (SELECT ManagerNIK FROM TB_M_Employee WHERE EmployeeName = emp.EmployeeName)) AS [Manager], comp.CompensationName, creq.EventDate, creq.RequestDate FROM TB_M_Employee emp
		JOIN TB_M_Position pos ON emp.PositionID = pos.PositionID
		JOIN TB_M_Department dep ON pos.DepartmentID = dep.DepartmentID
		JOIN TB_T_CompensationRequest creq ON emp.NIK = creq.NIK 
		JOIN TB_M_Compensation comp ON creq.CompensationID = comp.CompensationID
		JOIN TB_T_Approval app ON creq.RequestID = app.RequestID
		JOIN TB_M_Status st ON app.StatusID = st.StatusID 
	WHERE app.StatusID = (SELECT s.StatusID FROM TB_M_Status s WHERE s.StatusName  LIKE '%'+@Status+'%') AND
	app.DepartmentID = 
	(SELECT d.DepartmentID FROM TB_M_Department d WHERE d.DepartmentName LIKE '%'+@DepartmentName+'%' GROUP BY d.DepartmentID) GROUP BY creq.RequestID,emp.EmployeeName,emp.joinDate,comp.CompensationName,creq.EventDate,creq.RequestDate
	END
	GO

	-- Get Request List By NIK--
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveRequestListByNIK]
		@Status nvarchar(max),
		@DepartmentName nvarchar(max),
		@NIK nvarchar(max)
	AS
	BEGIN
	SELECT creq.RequestID, emp.EmployeeName, emp.JoinDate, (SELECT EmployeeName FROM TB_M_Employee WHERE NIK = (SELECT ManagerNIK FROM TB_M_Employee WHERE EmployeeName = emp.EmployeeName)) AS [Manager], comp.CompensationName, creq.EventDate, creq.RequestDate FROM TB_M_Employee emp
		JOIN TB_M_Position pos ON emp.PositionID = pos.PositionID
		JOIN TB_M_Department dep ON pos.DepartmentID = dep.DepartmentID
		JOIN TB_T_CompensationRequest creq ON emp.NIK = creq.NIK 
		JOIN TB_M_Compensation comp ON creq.CompensationID = comp.CompensationID
		JOIN TB_T_Approval app ON creq.RequestID = app.RequestID
		JOIN TB_M_Status st ON app.StatusID = st.StatusID 
	WHERE app.StatusID = (SELECT s.StatusID FROM TB_M_Status s WHERE s.StatusName  LIKE '%'+@Status+'%') AND
	app.DepartmentID = 
	(SELECT d.DepartmentID FROM TB_M_Department d WHERE d.DepartmentName LIKE '%'+@DepartmentName+'%' GROUP BY d.DepartmentID) AND creq.NIK = @NIK GROUP BY creq.RequestID,emp.EmployeeName,emp.joinDate,comp.CompensationName,creq.EventDate,creq.RequestDate
	END
	GO

	-- Get Approval Status
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveApprovalStatus]
	@RequestID int
	AS
	BEGIN
		SELECT st.StatusName,dep.DepartmentName AS Approval, app.ApprovalDate 
		FROM TB_M_Status st 
		JOIN TB_T_Approval app ON st.StatusID = app.StatusID 
		JOIN TB_M_Employee emp ON app.NIK = emp.NIK
		JOIN TB_M_Position pos ON emp.PositionID = pos.PositionID 
		JOIN TB_M_Department dep ON pos.DepartmentID = dep.DepartmentID
		WHERE app.RequestID = @RequestID
		GROUP BY PositionName, StatusName, DepartmentName, ApprovalDate
	END
	GO
	
	-- Get Detail Request--
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveDetailRequest]
		@RequestID int
	AS
	BEGIN
	SELECT creq.RequestID, emp.EmployeeName, emp.JoinDate, pos.PositionName, dep.DepartmentName, (SELECT EmployeeName FROM TB_M_Employee WHERE NIK = (SELECT ManagerNIK FROM TB_M_Employee WHERE EmployeeName = emp.EmployeeName)) AS [Manager], comp.CompensationName, creq.EventDate, creq.RequestDate FROM TB_M_Employee emp
		JOIN TB_M_Position pos ON emp.PositionID = pos.PositionID
		JOIN TB_M_Department dep ON pos.DepartmentID = dep.DepartmentID
		JOIN TB_T_CompensationRequest creq ON emp.NIK = creq.NIK 
		JOIN TB_M_Compensation comp ON creq.CompensationID = comp.CompensationID
		JOIN TB_T_Approval app ON creq.RequestID = app.RequestID
		JOIN TB_M_Status st ON app.StatusID = st.StatusID 
	WHERE creq.RequestID = @RequestID GROUP BY creq.RequestID, emp.EmployeeName, emp.joinDate, comp.CompensationName, creq.EventDate, creq.RequestDate, pos.PositionName, dep.DepartmentName
	END
	GO

	-- Get Document--
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveDocument]
		@RequestID int
	AS
	BEGIN
	SELECT doc.DocumentName, doc.Link FROM TB_M_Document doc WHERE doc.RequestID = @RequestID
	END
	GO

	--update status, set pending to next department if not rejected
	CREATE OR ALTER PROCEDURE [dbo].[SP_UpdateStatus] 
	@RequestID int,
	@DepartmentID int,
	@StatusName nvarchar(max),
	@NIK nvarchar(450),
	@DetailInfo nvarchar(max)
	AS
	BEGIN
		DECLARE @NewStatusID int
		SET @NewStatusID = (SELECT StatusID FROM TB_M_Status WHERE StatusName LIKE '%'+@StatusName+'%')

		DECLARE @PendingID int
		SET @PendingID = (SELECT StatusID FROM TB_M_Status WHERE StatusName LIKE '%Pending%')

		DECLARE @RejectedID int
		SET @RejectedID = (SELECT StatusID FROM TB_M_Status WHERE StatusName LIKE '%Rejected%')

		DECLARE @FinanceID int
		DECLARE @HRID int
		SET @FinanceID = (SELECT DepartmentID FROM TB_M_Department WHERE DepartmentName LIKE '%Finance%')
		SET @HRID = (SELECT DepartmentID FROM TB_M_Department WHERE DepartmentName LIKE '%HR%')

		IF (@DepartmentID != @FinanceID) AND (@NewStatusID != @RejectedID)
		BEGIN
			IF (@DepartmentID = @HRID)
			BEGIN
				INSERT INTO TB_T_Approval (StatusID, NIK, RequestID, DepartmentID, ApprovalDate)
				VALUES (@PendingID, @NIK, @RequestID, @FinanceID, GETDATE())

				UPDATE TB_T_Approval
				SET StatusID = @NewStatusID, ApprovalDate = GETDATE(), NIK = @NIK
				WHERE RequestID = @RequestID AND DepartmentID = @DepartmentID AND StatusID = @PendingID
			END
			ELSE
			BEGIN
				INSERT INTO TB_T_Approval (StatusID, NIK, RequestID, DepartmentID, ApprovalDate)
				VALUES (@PendingID, @NIK, @RequestID, @HRID, GETDATE())

				UPDATE TB_T_Approval
				SET StatusID = @NewStatusID, ApprovalDate = GETDATE(), NIK = @NIK
				WHERE RequestID = @RequestID AND DepartmentID = @DepartmentID AND StatusID = @PendingID
			END
		END
		ELSE
		BEGIN
			UPDATE TB_T_Approval
			SET StatusID = @NewStatusID, ApprovalDate = GETDATE(), NIK = @NIK, Note = @DetailInfo
			WHERE RequestID = @RequestID AND DepartmentID = @DepartmentID AND StatusID = @PendingID
		END
	END
	GO

	-- Get Count Employee
	CREATE OR ALTER PROCEDURE [dbo].[SP_CountEmployee]
	AS
	BEGIN
		SELECT COUNT(NIK) AS Total FROM TB_M_Employee
	END
	GO

	-- Get Count Wedding Gift
	CREATE OR ALTER PROCEDURE [dbo].[SP_CountWedding]
	AS
	BEGIN
		SELECT COUNT(creq.CompensationID) AS Total FROM TB_T_CompensationRequest creq 
		JOIN TB_M_Compensation comp ON creq.CompensationID = comp.CompensationID 
		WHERE comp.CompensationName LIKE '%Wedding%'
	END
	GO

	-- Get Count Wedding Gift
	CREATE OR ALTER PROCEDURE [dbo].[SP_CountBaby]
	AS
	BEGIN
		SELECT COUNT(creq.CompensationID) AS Total FROM TB_T_CompensationRequest creq 
		JOIN TB_M_Compensation comp ON creq.CompensationID = comp.CompensationID 
		WHERE comp.CompensationName LIKE '%Baby%'
	END
	GO

	-- Get Count Wedding Gift
	CREATE OR ALTER PROCEDURE [dbo].[SP_CountGrief]
	AS
	BEGIN
		SELECT COUNT(creq.CompensationID) AS Total FROM TB_T_CompensationRequest creq 
		JOIN TB_M_Compensation comp ON creq.CompensationID = comp.CompensationID 
		WHERE comp.CompensationName LIKE '%Grief%'
	END
	GO

	CREATE PROCEDURE [dbo].[SP_RetrieveCompensation]
	AS
	BEGIN
		SELECT * FROM TB_M_Compensation 
	END
	GO