
------------------- crsId -> showTopics --------------
CREATE PROC GetTopicsForCourse
    @Crs_id INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Course WHERE Crs_id = @Crs_id)
        BEGIN
            SELECT Topic_id, Topic_name
            FROM Topic
            WHERE Topic_id IN (SELECT Topic_id FROM Course WHERE Crs_id = @Crs_id);
        END
        ELSE
        BEGIN
            PRINT 'Course does not exist.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while getting topics for the course.';
    END CATCH
END;


EXEC GetTopicsForCourse @Crs_id=1;

------------------ stdId-> exams, gradeOfEachExam --------------

CREATE PROC GetStudentExamsAndGrades
    @St_id INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Student WHERE St_id = @St_id)
        BEGIN
            SELECT E.Exam_Name, SE.Grade
            FROM Student_Exams SE
            JOIN Exam E ON SE.Exam_id = E.Ex_id
            WHERE SE.Student_id = @St_id;
        END
        ELSE
        BEGIN
            PRINT 'Student does not exist.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while getting exams and grades for the student.';
    END CATCH
END;

Exec GetStudentExamsAndGrades @st_id=1;

---------- stdID, examID -> examAnswers, std_answers, modelAns ---------

CREATE PROC GetExamDetailsForStudent
    @St_id INT,
    @Ex_id INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Student WHERE St_id = @St_id) AND EXISTS (SELECT 1 FROM Exam WHERE Ex_id = @Ex_id)
        BEGIN
            SELECT
				Question.Q_content,
                Question.Q_type,
                Question.Model_answer,
                Exam_Std_Question.Std_answer
            FROM      
                Exam
                INNER JOIN Exam_Question ON Exam.Ex_id = Exam_Question.Ex_id 
                INNER JOIN Exam_Std_Question ON Exam.Ex_id = Exam_Std_Question.Ex_id 
                INNER JOIN Question ON Exam_Question.Q_id = Question.Q_id AND Exam_Std_Question.Q_id = Question.Q_id 
                INNER JOIN Student_Exams ON Exam.Ex_id = Student_Exams.Exam_id AND @St_id = Student_Exams.Student_id
            WHERE
                Exam.Ex_id = @Ex_id
        END
        ELSE
        BEGIN
            PRINT 'Student ID or Exam ID does not exist.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while retrieving exam details for the student.';
    END CATCH
END;


EXEC GetExamDetailsForStudent @St_id = 1, @Ex_id = 13;


