-----------------Stored Procedre For Questions---------------

----------------------------------Add Question-------------------------------------------------------
-- this proc insert question into DB and assign at output param the id of generated exam
-- to be used when we need to add choices
CREATE PROCEDURE addQuestion
	@quest_content NVARCHAR(max) ,
	@quest_type NVARCHAR(30),
	@modelAns NVARCHAR(max)  ,
	@Course_id INT,
	@questionId INT OUT
AS
BEGIN
	INSERT INTO Question (Q_content, Q_type, Model_answer, Course_id) VALUES
		(@quest_content,@quest_type,@modelAns,@Course_id)
		SET @questionId  =  SCOPE_IDENTITY()
END;

-------------------------------update Question----------------------------------------------------------
CREATE PROCEDURE updateQuestion
	@questionId INT,
	@quest_content NVARCHAR(max) ,
	@quest_type NVARCHAR(30),
	@modelAns NVARCHAR(max)  ,
	@Course_id INT
AS
BEGIN
	UPDATE Question SET 
		Q_content = @quest_content,
		Q_type = @quest_type,
		Model_answer = @modelAns,
		Course_id = @Course_id
	WHERE Q_id = @questionId
END;
----------------------------------------Delete Question-------------------------------------------------
CREATE PROCEDURE deleteQuestion		-- Dont delete the old one
	@questionId INT
AS
BEGIN
	DELETE FROM Question WHERE Q_id = @questionId;
END;

--UpdatedVersion
ALTER Procedure deleteQuestion
	@questionId int
AS
BEGIN 
	delete from Question_choices where Question_choices.Q_id = @questionId
	delete from Question where Q_id = @questionId
END;

------------------------------Add Question Choices-----------------------------------------------------------
CREATE PROCEDURE addQuestionChoices
	@question_id INT,
	@choice1 NVARCHAR(40) ,
	@choice2 NVARCHAR(40) ,
	@choice3 NVARCHAR(40) ,
	@choice4 NVARCHAR(40) 
AS
BEGIN
	INSERT INTO Question_choices VALUES
	(@question_id, @choice1),
	(@question_id, @choice2),
	(@question_id, @choice3),
	(@question_id, @choice4)
END;

---------------------------------update Question Choices---------------------------------------
CREATE PROCEDURE updateQuestionChoices
	@question_id INT,
	@choice1 NVARCHAR(40) ,
	@choice2 NVARCHAR(40) ,
	@choice3 NVARCHAR(40) ,
	@choice4 NVARCHAR(40) 
AS
BEGIN
	WITH Choices AS (
        SELECT Q_choice, ROW_NUMBER() OVER (ORDER BY Q_choice) AS rn
        FROM Question_choices
        WHERE Q_id = @question_id
    )
    UPDATE Choices
    SET Q_choice = 
        CASE 
            WHEN rn = 1 THEN @choice1
            WHEN rn = 2 THEN @choice2
            WHEN rn = 3 THEN @choice3
            WHEN rn = 4 THEN @choice4
        END;
END;

----------------------------------delete Question Choices------------------------------------------
CREATE PROCEDURE deleteQuestionChoices
	@questionId INT
AS
BEGIN
	DELETE FROM Question_choices WHERE Q_id = @questionId;
END;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------