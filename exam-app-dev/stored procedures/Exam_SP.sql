--------------------------------Stored Procedure For Exam----------------------

----------------------------Get Exam Details------------------------

CREATE PROCEDURE GetExamDetails
(
    @exam_id INT
)
AS
BEGIN
    SELECT 
	    ex.Exam_Name AS Exam_Name,
        q.Q_id AS Question_ID,
        q.Q_content AS Question_Content,
        qc.Q_choice AS Question_Choice
    FROM 
        Exam ex
    INNER JOIN 
        Exam_Question eq ON ex.Ex_id = eq.Ex_id
    INNER JOIN 
        Question q ON eq.Q_id = q.Q_id
    INNER JOIN 
        Question_choices qc ON q.Q_id = qc.Q_id
    WHERE 
        ex.Ex_id = @exam_id;
END;

----------------------------Generate Exam------------------------
CREATE PROCEDURE generateExam 
	@crsId INT ,
	@examName NVARCHAR(50),
	@numOfTF INT , 
	@numOfChoose INT, 
	@examDuration INT,
	@examDate DATE,
	@examId INT OUTPUT
AS  
	INSERT INTO Exam (Ex_date, Ex_duration, Exam_Name, Course_id) VALUES(@examDate, @examDuration, @examName, @crsId)
	SET @examId =  SCOPE_IDENTITY() -- get last identity value generated
	INSERT INTO Exam_Question (Ex_id, Q_id)
	SELECT @examId, Q_id FROM
	(
		SELECT TOP (@numOfTF) Q_id FROM Question WHERE Course_id = @crsId AND
			Q_type = 'TorF' ORDER BY NEWID()
		UNION ALL
		SELECT TOP (@numOfChoose) Q_id FROM Question WHERE Course_id = @crsId AND 
			Q_type = 'Choose' ORDER BY NEWID()

	) AS RandomQuestions;

-------------------------------Update Exam------------------------

CREATE PROCEDURE updateExam 
	@examId INT,
	@examName NVARCHAR(50),
	@examDate DATE,
	@examDuration INT,
	@crsId INT
AS  
	UPDATE Exam SET Exam_Name = @examName , Ex_date = @examDate, 
		Ex_duration = @examDuration, Course_id = @crsId WHERE Ex_id = @examId

---------------------------------Regenerate Exam Questions-------------------------------------------------
CREATE PROCEDURE regenerateExamQuestions
	@examId INT,
	@numOfTF INT , 
	@numOfChoose INT,
	@crsId INT
AS
	DELETE FROM Exam_Question WHERE Ex_id = @examId
	INSERT INTO Exam_Question (Ex_id, Q_id)
	SELECT @examId, Q_id FROM
	(
		SELECT TOP (@numOfTF) Q_id FROM Question WHERE Course_id = @crsId AND
			Q_type = 'TorF' ORDER BY NEWID()
		UNION ALL
		SELECT TOP (@numOfChoose) Q_id FROM Question WHERE Course_id = @crsId AND 
			Q_type = 'Choose' ORDER BY NEWID()

	) AS RandomQuestions;

-------------------------------------Delete Exam----------------------------------------------------
CREATE PROCEDURE deleteExam
	@examId INT
AS
BEGIN
	DELETE FROM Exam_Question WHERE Ex_id = @examId;
	DELETE FROM Exam WHERE Ex_id = @examId
END;
-----------------------------Correct And Calculate Final Grade--------------------------------------------------
create PROCEDURE CorrectAndCalculateFinalGrade
    @StudentID INT,
    @ExamID INT,
    @FinalGrade INT OUTPUT
AS
BEGIN
    DECLARE @TotalCorrectAnswers INT;

    -- Calculate the total number of correct answers
    SELECT @TotalCorrectAnswers = COUNT(*)
    FROM Exam_Std_Question AS ESQ
    INNER JOIN Question AS q ON ESQ.Q_id = q.Q_id
    WHERE ESQ.St_id = @StudentID AND esq.Ex_id = @ExamID AND ESQ.Std_answer = q.Model_answer;

    SET @FinalGrade = @TotalCorrectAnswers * 10;
END;

-----------------------------------Insert Exam Question--------------------------------------------
CREATE PROCEDURE InsertExamQuestion
    @Ex_id INT,
    @Q_id INT
AS
BEGIN
    INSERT INTO Exam_Question(Ex_id, Q_id)
    VALUES (@Ex_id, @Q_id);
END;

--------------------------------------Update Exam Question---------------------------------------------------

CREATE PROCEDURE UpdateExamQuestion 
    @Ex_id INT,
    @old_Q_id INT ,
	@new_Q_id INT
AS
BEGIN
    UPDATE Exam_Question
    SET Q_id = @new_Q_id
    WHERE Ex_id = @Ex_id and Q_id=@old_Q_id;
END;

----------------------------------Delete Exam Question-------------------------------------------------------
CREATE PROCEDURE DeleteExamQuestion
    @Ex_id INT,
    @Q_id INT
AS
BEGIN
    DELETE FROM Exam_Question
    WHERE Ex_id = @Ex_id AND Q_id = @Q_id;
END;