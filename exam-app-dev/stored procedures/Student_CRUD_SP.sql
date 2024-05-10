
-----------------------------------------
------------- Student CRUD --------------
-----------------------------------------

------------- insert Student ------------

CREATE PROC InsertStudent
    @St_fname VARCHAR(50),
    @St_lname VARCHAR(50),
    @St_gender VARCHAR(10),
    @St_birthdate DATE,
    @City VARCHAR(50),
    @Street VARCHAR(50),
    @St_phone INT,
    @User_id INT
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Student WHERE St_fname = @St_fname AND St_lname = @St_lname AND St_birthdate = @St_birthdate)
        BEGIN
            INSERT INTO Student (St_fname, St_lname, St_gender, St_birthdate, City, Street, St_phone, User_id)
            VALUES (@St_fname, @St_lname, @St_gender, @St_birthdate, @City, @Street, @St_phone, @User_id);

            PRINT 'Student inserted successfully.';
        END
        ELSE
        BEGIN
            PRINT 'Student already exists.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while inserting the student.';
    END CATCH
END;

EXEC InsertStudent
    @St_fname = 'John',
    @St_lname = 'Doe',
    @St_gender = 'Male',
    @St_birthdate = '2000-01-01',
    @City = 'City',
    @Street = 'Street',
    @St_phone = 123456789,
    @User_id = 1;


---------------- Update Student ------------

CREATE PROC UpdateStudent
    @St_id INT,
    @NewSt_fname VARCHAR(50),
    @NewSt_lname VARCHAR(50),
    @NewSt_gender VARCHAR(10),
    @NewSt_birthdate DATE,
    @NewCity VARCHAR(50),
    @NewStreet VARCHAR(50),
    @NewSt_phone INT,
    @NewUser_id INT
AS
BEGIN
    BEGIN TRY
        UPDATE Student
        SET St_fname = @NewSt_fname,
            St_lname = @NewSt_lname,
            St_gender = @NewSt_gender,
            St_birthdate = @NewSt_birthdate,
            City = @NewCity,
            Street = @NewStreet,
            St_phone = @NewSt_phone,
            User_id = @NewUser_id
        WHERE St_id = @St_id;
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while updating the student.';
    END CATCH
END;

EXEC UpdateStudent
    @St_id = 1,
    @NewSt_fname = 'fatma',
    @NewSt_lname = 'Sorour',
    @NewSt_gender = 'female',
    @NewSt_birthdate = '2001-06-08',
    @NewCity = 'Qwesna',
    @NewStreet = '1st',
    @NewSt_phone = 01234978234,
    @NewUser_id = 2;

--------------- Delete Student --------------

CREATE PROC DeleteStudent
    @St_id INT
AS
BEGIN
    BEGIN TRY
        DECLARE @RowCount INT;

        SELECT @RowCount = COUNT(*) FROM Student WHERE St_id = @St_id;

        IF @RowCount > 0
        BEGIN
            DELETE FROM Student_Courses WHERE Std_id = @St_id;
            DELETE FROM Student WHERE St_id = @St_id;

            PRINT 'Student deleted successfully.';
        END
        ELSE
        BEGIN
            PRINT 'Student does not exist.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while deleting the student. ' + ERROR_MESSAGE();
    END CATCH
END;

EXEC DeleteStudent @St_id = 4;



