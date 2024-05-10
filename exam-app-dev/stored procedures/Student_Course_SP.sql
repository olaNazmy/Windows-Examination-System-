-----------------------------------------
------------- Student_Course CRUD --------------
-----------------------------------------

------------- insert Student into Course ------------

CREATE PROC InsertStudentIntoCourse
    @Std_id INT,
    @Crs_id INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Student WHERE St_id = @Std_id) AND EXISTS (SELECT 1 FROM Course WHERE Crs_id = @Crs_id)
        BEGIN
            INSERT INTO Student_Courses (Std_id, Crs_id)
            VALUES (@Std_id, @Crs_id);

            PRINT 'Student added to course successfully.';
        END
        ELSE
        BEGIN
            PRINT 'Student or Course does not exist.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while adding the student to the course. ' + ERROR_MESSAGE();
    END CATCH
END;

EXEC InsertStudentIntoCourse @Std_id = 1, @Crs_id = 1000;

------------- Update Student's Course ------------
CREATE PROC UpdateStudentCourse
    @Std_id INT,
    @Old_Crs_id INT,
    @New_Crs_id INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Student_Courses WHERE Std_id = @Std_id AND Crs_id = @Old_Crs_id) AND EXISTS (SELECT 1 FROM Course WHERE Crs_id = @New_Crs_id)
        BEGIN
            UPDATE Student_Courses
            SET Crs_id = @New_Crs_id
            WHERE Std_id = @Std_id AND Crs_id = @Old_Crs_id;

            PRINT 'Student course updated successfully.';
        END
        ELSE
        BEGIN
            PRINT 'Student is not enrolled in the old course or the new course does not exist.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while updating the student course. ' + ERROR_MESSAGE();
    END CATCH
END;

EXEC UpdateStudentCourse @Std_id = 1, @Old_Crs_id = 1000, @New_Crs_id = 900;

---------------- Delete Student From Course -----------
CREATE PROC RemoveStudentFromCourse
    @Std_id INT,
    @Crs_id INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Student_Courses WHERE Std_id = @Std_id AND Crs_id = @Crs_id)
        BEGIN
            DELETE FROM Student_Courses
            WHERE Std_id = @Std_id AND Crs_id = @Crs_id;

            PRINT 'Student removed from course successfully.';
        END
        ELSE
        BEGIN
            PRINT 'Student is not enrolled in the specified course or this course doesnot exist.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while removing the student from the course. ' + ERROR_MESSAGE();
    END CATCH
END;

EXEC RemoveStudentFromCourse @Std_id = 1, @Crs_id = 101;
