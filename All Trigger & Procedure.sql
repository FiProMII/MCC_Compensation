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

		INSERT TB_T_Approval 
		SELECT @StatusID,@NIK,RequestID,@DepartmentID,GETDATE()
		FROM inserted
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
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveCompensation]
	AS
	BEGIN
		SELECT 
		SUM(CASE WHEN CompensationID = 1 THEN CompensationID ELSE 0 END) AS [Wedding],
		SUM(CASE WHEN CompensationID = 2 THEN CompensationID ELSE 0 END) AS [Baby Gift],
		SUM(CASE WHEN CompensationID = 3 THEN CompensationID ELSE 0 END) AS [Duka],
		YEAR(RequestDate) AS [Year]
		FROM TB_T_CompensationRequest GROUP BY YEAR(RequestDate)
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
	CREATE OR ALTER PROCEDURE SP_RetrieveDataStatus
		@Status nvarchar(max)
	AS
	BEGIN
	SELECT creq.RequestID, emp.EmployeeName, emp.JoinDate, (SELECT EmployeeName FROM TB_M_Employee WHERE NIK = (SELECT ManagerNIK FROM TB_M_Employee WHERE EmployeeName = emp.EmployeeName)) AS [Manager], comp.CompensationName, creq.EventDate, creq.RequestDate FROM TB_M_Employee emp
	JOIN TB_T_CompensationRequest creq ON emp.NIK = creq.NIK 
	JOIN TB_M_Compensation comp ON creq.CompensationID = comp.CompensationID
	JOIN TB_T_Approval app ON creq.RequestID = app.RequestID
	JOIN TB_M_Status st ON app.StatusID = st.StatusID WHERE st.StatusName LIKE '%'+@Status+'%'
	GROUP BY creq.RequestID,emp.EmployeeName,emp.joinDate,comp.CompensationName,creq.EventDate,creq.RequestDate
	END
	GO

	-- Get Approval Status
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveApprovalStatus]
	@RequestID int
	AS
	BEGIN
		SELECT st.StatusName,CONCAT(pos.PositionName, '-',dep.DepartmentName) AS Approval, app.ApprovalDate 
		FROM TB_M_Status st 
		JOIN TB_T_Approval app ON st.StatusID = app.StatusID 
		JOIN TB_M_Employee emp ON app.NIK = emp.NIK
		JOIN TB_M_Position pos ON emp.PositionID = pos.PositionID 
		JOIN TB_M_Department dep ON pos.DepartmentID = dep.DepartmentID
		WHERE app.RequestID = @RequestID
		GROUP BY PositionName, StatusName, DepartmentName, ApprovalDate
	END
	GO
	
	--update status, set pending to next department if not rejected
	CREATE OR ALTER PROCEDURE SP_UpdateStatus 
	@RequestID int,
	@DepartmentID int,
	@NewStatusID int,
	@NIK nvarchar(450)
	AS
	BEGIN
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
				INSERT INTO TB_T_Approval (StatusID, RequestID, DepartmentID, ApprovalDate)
				VALUES (@PendingID, @RequestID, @FinanceID, GETDATE())

				UPDATE TB_T_Approval
				SET StatusID = @NewStatusID, ApprovalDate = GETDATE(), NIK = @NIK
				WHERE RequestID = @RequestID AND DepartmentID = @DepartmentID AND StatusID = 1
			END
			ELSE
			BEGIN
				INSERT INTO TB_T_Approval (StatusID, RequestID, DepartmentID, ApprovalDate)
				VALUES (@PendingID, @RequestID, @HRID, GETDATE())

				UPDATE TB_T_Approval
				SET StatusID = @NewStatusID, ApprovalDate = GETDATE(), NIK = @NIK
				WHERE RequestID = @RequestID AND DepartmentID = @DepartmentID AND StatusID = 1
			END
		END
		ELSE
		BEGIN
			UPDATE TB_T_Approval
			SET StatusID = @NewStatusID, ApprovalDate = GETDATE(), NIK = @NIK
			WHERE RequestID = @RequestID AND DepartmentID = @DepartmentID AND StatusID = 1
		END
	END