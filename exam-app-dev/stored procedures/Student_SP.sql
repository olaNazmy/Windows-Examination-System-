-----------------Stored Procedre For Student---------------

-------------------------------Calculate Total Grade----------------------------
CREATE OR ALTER PROC CalculateTotalGrade 
	@Student_Id INT,
	@Course_Id INT
AS
BEGIN
-- Check if the STUDENT And Cousre exists in [dbo].[Student_Courses]
	IF NOT EXISTS (SELECT 1 FROM  [dbo].[Student_Courses]
					WHERE Std_id = @Student_Id  AND Crs_id = @Course_Id)
	BEGIN
		SELECT 'STUDENT Id And Cousre Id is not valid.' AS ResultMessage
        RETURN
	END

	DECLARE @AverageGrade DECIMAL(10, 2);

SELECT @AverageGrade = AVG(Grade) 
	FROM [dbo].[Student_Exams] 
	JOIN [dbo].[Exam]  ON Exam_id = Ex_id
	WHERE Course_id = @Course_Id;

UPDATE [dbo].[Student_Courses]
	SET [Total_Grade] = @AverageGrade 
	WHERE Std_id = @Student_Id AND Crs_id = @Course_Id;

END;

---------------------------Store Student Answer-------------------------
CREATE OR ALTER PROC StoreStudentsAnswers
	@StudentId INT,
	@ExamId INT,
	@QestionsId INT,
	@Answer VARCHAR(20)
AS 
BEGIN
-- Check if the @StudentId and @ExamId exist in the [dbo].[Student_Exames] table
	IF NOT EXISTS(SELECT 1 FROM [dbo].[Student_Exams] 
					WHERE [Student_id] = @StudentId AND [Exam_id] = @ExamId)
	BEGIN
		SELECT 'Invalid Student Id with Exam Id.' AS ResultMessage
        RETURN
	END;
-- Check if the Question is in the [dbo].[Exam_Question] table
	IF NOT EXISTS (SELECT 1 FROM [dbo].[Exam_Question] 
		WHERE [Ex_id] = @ExamId  AND [Q_id] = @QestionsId)
	BEGIN
		SELECT 'Question id is not valid.' AS ResultMessage
        RETURN
	END;
-- Check if the Student anwser has been stored before.
	IF EXISTS (SELECT 1 FROM [dbo].[Exam_Std_Question]
				WHERE [St_id] = @StudentId AND [Ex_id] = @ExamId AND [Q_id] = @QestionsId)
	BEGIN
		SELECT 'Student anwser has been stored before.' AS ResultMessage
        RETURN
	END;

	INSERT INTO [dbo].[Exam_Std_Question]
	VALUES (@StudentId,@ExamId, @QestionsId, @Answer);

End;

---------------------------- Get Students By Track Id----------------------------

CREATE PROCEDURE get_Students_By_TrackId
	@trackId INT
AS
BEGIN
	SELECT st.Track_id, s.* FROM Students_InTracks st left join Student s
		ON s.St_id=st.Student_Id
		WHERE st.Track_id=@trackId
 END;


 -----------------------------------Get Student Exam Grades-----------------------------------------
 CREATE PROCEDURE GetStudentExamGrades
AS
BEGIN
    SELECT
        Student_id,
        Exam_id,
        Grade
    FROM
        Student_Exams;
END;

------------------------------------ Insert Student Exam Grade----------------------------------------------------------
CREATE PROCEDURE InsertStudentExamGrade
    @Student_id INT,
    @Exam_id INT,
    @Grade INT
AS
BEGIN
    -- Check if @Exam_id exists in the Exam table
    IF EXISTS (SELECT 1 FROM Exam WHERE Ex_id = @Exam_id)
    BEGIN
        -- Insert the record into Student_Exams table
        INSERT INTO Student_Exams (Student_id, Exam_id, Grade)
        VALUES (@Student_id, @Exam_id, @Grade);
    END
    ELSE
    BEGIN
        -- Handle the case where @Exam_id does not exist
        PRINT 'Error: The provided Exam_id does not exist in the Exam table.';
    END
END;

-------------------------------------Update Student Exam Grade-----------------------------------------
CREATE PROCEDURE UpdateStudentExamGrade
    @Student_id INT,
    @Exam_id INT,
    @NewGrade INT
AS
BEGIN
    -- Check if the record exists before updating
    IF EXISTS (SELECT 1 FROM Student_Exams WHERE Student_id = @Student_id AND Exam_id = @Exam_id)
    BEGIN
        -- Update the grade for the specified student and exam
        UPDATE Student_Exams
        SET Grade = @NewGrade
        WHERE Student_id = @Student_id AND Exam_id = @Exam_id;
        
        PRINT 'Record updated successfully.';
    END
    ELSE
    BEGIN
        -- Handle the case where the record does not exist
        PRINT 'Error: The specified record does not exist.';
    END
END;

--------------------------------------Delete Student Exam Grade-------------------------------------------
CREATE PROCEDURE DeleteStudentExamGrade
    @Student_id INT,
    @Exam_id INT
AS
BEGIN
    -- Check if the record exists before deleting
    IF EXISTS (SELECT 1 FROM Student_Exams WHERE Student_id = @Student_id AND Exam_id = @Exam_id)
    BEGIN
        -- Delete the record with the specified Student_id and Exam_id
        DELETE FROM Student_Exams
        WHERE Student_id = @Student_id AND Exam_id = @Exam_id;
        
        PRINT 'Record deleted successfully.';
    END
    ELSE
    BEGIN
        -- Handle the case where the record does not exist
        PRINT 'Error: The specified record does not exist.';
    END
END;
---------------------------------Assign Student To Exam--------------------------------------------------
CREATE PROCEDURE assignStdToExam
	@std_id INT,
	@exam_id NVARCHAR(40)	
AS
BEGIN
	INSERT INTO Student_Exams (Exam_id, Student_id) VALUES (@exam_id, @std_id)
END;