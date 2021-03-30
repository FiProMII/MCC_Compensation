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

	-- Insert to TB_T_Approval first as status pending
	CREATE OR ALTER TRIGGER [dbo].[T_CompensationRequest] ON [dbo].[TB_T_CompensationRequest]
	AFTER INSERT AS
	BEGIN
		DECLARE @StatusID INT
		DECLARE @NIK nvarchar(450)
		DECLARE @Info nvarchar(450)
		SET @StatusID = (SELECT StatusID FROM TB_M_Status WHERE StatusName LIKE '%Pending%') 
		SET @NIK = (SELECT ManagerNIK FROM TB_M_Employee WHERE NIK = (SELECT NIK FROM inserted))
		SET @Info = '0'

		INSERT TB_T_Approval 
		SELECT @StatusID,@NIK,RequestID,GETDATE(),@Info
		FROM inserted
	END
	GO

---------------------------------------- P R O C E D U R E -----------------------------------------------
	-- Delete all accountrole by id
	CREATE OR ALTER PROCEDURE [dbo].[SP_DeleteAccountRoleByID]
	@nik nvarchar(450)
	AS
	BEGIN
		DELETE FROM TB_T_AccountRole WHERE NIK = @nik
	END
	GO

	-- get all accountrole by id
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveAccountRoleByID]
	@nik nvarchar(450)
	AS
	BEGIN
		SELECT * FROM TB_T_AccountRole
		WHERE NIK = @nik
	END
	GO

	-- Get nik & email for validation
	CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveNIKEmail]
		@Params varchar(max)
	AS
	BEGIN
		SELECT * FROM TB_M_Employee WHERE Email = @Params
	END
	GO

	-- Get Compensation for Chart
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
	
	--get email manager
	CREATE OR ALTER PROCEDURE SP_RetrieveManagerEmail
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

	CREATE OR ALTER PROCEDURE SP_RetrieveDataStatus
		@Status nvarchar(max),
		@Information nvarchar(max)
	AS
	BEGIN
	SELECT creq.RequestID, emp.EmployeeName, emp.JoinDate, (SELECT EmployeeName FROM TB_M_Employee WHERE NIK = (SELECT ManagerNIK FROM TB_M_Employee WHERE EmployeeName = emp.EmployeeName)) AS [Manager], comp.CompensationName, creq.EventDate, creq.RequestDate FROM TB_M_Employee emp
	JOIN TB_T_CompensationRequest creq ON emp.NIK = creq.NIK 
	JOIN TB_M_Compensation comp ON creq.CompensationID = comp.CompensationID
	JOIN TB_T_Approval app ON creq.RequestID = app.RequestID
	JOIN TB_M_Status st ON app.StatusID = st.StatusID WHERE st.StatusName LIKE '%'+@Status+'%' AND app.Information=@Information
	GROUP BY creq.RequestID,emp.EmployeeName,emp.joinDate,comp.CompensationName,creq.EventDate,creq.RequestDate
	END
	GO