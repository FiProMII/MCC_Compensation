
-- set managerNIK to null when manager is deleted
CREATE OR ALTER   TRIGGER [dbo].[T_DeleteManager] ON [dbo].[TB_M_Account]
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

-- insert account with default pass before inserting to employee
CREATE OR ALTER TRIGGER [dbo].[T_Employee] ON [dbo].[TB_M_Employee]
INSTEAD OF INSERT AS
BEGIN
	INSERT TB_M_Account
	SELECT NIK, NEWID()
	FROM inserted

	INSERT TB_M_Employee
	SELECT *
	FROM inserted
END
Go

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

-- SP login
CREATE OR ALTER PROCEDURE SP_RetrieveLogin
	@Email nvarchar(max),
	@Password nvarchar(max)
AS
BEGIN
	DECLARE @Id nvarchar(max)
	
    SET @Id = (SELECT A.NIK FROM TB_M_Account A 
				JOIN TB_M_Employee E 
				ON A.NIK = E.NIK 
				WHERE E.Email=@Email)
	SELECT 
		EmployeeName,
		RoleName, 
		Email
	FROM TB_M_Employee E
		JOIN TB_M_Account A 
		ON E.NIK = A.NIK
			JOIN TB_T_AccountRole AR 
			ON A.NIK = AR.NIK
				JOIN TB_M_Role R 
				ON AR.RoleID = R.RoleID
	WHERE E.NIK = @Id and A.Password = @Password
END

-- get nik & email for validation
CREATE OR ALTER PROCEDURE [dbo].[SP_RetrieveNIKEmail]
@Params varchar(max)
AS
BEGIN
	SELECT * FROM TB_M_Employee WHERE Email = @Params OR NIK = @Params
END
GO
