---------------------Stored Procedure For Login Account------------------------


-----------------------------Select Login Accounts----------------------------------
CREATE PROCEDURE SelectLoginAccounts	
AS
BEGIN
    -- Select all columns from the Login_Accounts table
    SELECT User_id, UserName, Password, Role
    FROM Login_Accounts;
END;
---------------------------Insert Login Account------------------------------------

CREATE PROCEDURE InsertLoginAccount
    @UserName NVARCHAR(50),
    @Password NVARCHAR(50),
    @Role NVARCHAR(10)
AS
BEGIN
    -- Insert a new login account into the Login_Accounts table
    INSERT INTO Login_Accounts( UserName, Password, Role)
    VALUES (@UserName, @Password, @Role);

    PRINT 'Login account inserted successfully.';
END;

------------------------------Update Login Account---------------------------------
CREATE PROCEDURE UpdateLoginAccount		
    @User_id INT,
    @UserName NVARCHAR(50),
    @Password NVARCHAR(50),
    @Role NVARCHAR(10)
AS
BEGIN
    -- Check if the login account exists before updating
    IF EXISTS (SELECT 1 FROM Login_Accounts WHERE User_id = @User_id)
    BEGIN
        -- Update the login account information
        UPDATE Login_Accounts
        SET UserName = @UserName,
            Password = @Password,
            Role = @Role
        WHERE User_id = @User_id;
        
        PRINT 'Login account updated successfully.';
    END
    ELSE
    BEGIN
        -- Handle the case where the login account does not exist
        PRINT 'Error: The specified login account does not exist.';
    END
END;

---------------------------Delete Login Account------------------------------------
CREATE PROCEDURE DeleteLoginAccount
    @User_id INT
AS
BEGIN
    -- Check if the login account exists before deleting
    IF EXISTS (SELECT 1 FROM Login_Accounts WHERE User_id = @User_id)
    BEGIN
        -- Delete the login account with the specified User_id
        DELETE FROM Login_Accounts
        WHERE User_id = @User_id;
        
        PRINT 'Login account deleted successfully.';
    END
    ELSE
    BEGIN
        -- Handle the case where the login account does not exist
        PRINT 'Error: The specified login account does not exist.';
    END
END;
---------------------------------------------------------------
---------------------------------------------------------------