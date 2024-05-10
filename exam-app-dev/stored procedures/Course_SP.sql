-----------------Stored Procedre For Course---------------

--------------------------------Insert Course----------------------------------
CREATE OR ALTER PROC InsertCourse
	@Crs_name VARCHAR(50),
	@Crs_duration INT,
	@Topic_id	  INT
AS
BEGIN
	INSERT INTO [dbo].[Course]
	VALUES(@Crs_name,@Crs_duration,@Topic_id)
END;

------------------------------------Update Course Name---------------------------------------
CREATE OR ALTER PROC UpdateCourseName
	@Crs_name VARCHAR(50),
	@Crs_id INT
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM [dbo].[Course]  WHERE Crs_id = @Crs_id)
	BEGIN
		SELECT 'Course does not Exists' AS ResultMessage
		RETURN
	END

	UPDATE [dbo].[Course]
	SET Crs_name = @Crs_name WHERE Crs_id = @Crs_id;
END;

---------------------------------Update Course Topic-----------------------------------------------
CREATE OR ALTER PROC UpdateCourseTopic
	@Topic_id INT,
	@Crs_id INT
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM [dbo].[Course]  WHERE Crs_id = @Crs_id)
	BEGIN
		SELECT 'Course does not Exists' AS ResultMessage
		RETURN
	END

	UPDATE [dbo].[Course]
	SET Topic_id = @Topic_id WHERE Crs_id = @Crs_id;
END;

---------------------------------Update Course Duration--------------------------------------------------------
CREATE OR ALTER PROC UpdateCourseDuration
	@Crs_duration INT,
	@Crs_id INT
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM [dbo].[Course]  WHERE Crs_id = @Crs_id)
	BEGIN
		SELECT 'Course does not Exists' AS ResultMessage
		RETURN
	END

	UPDATE [dbo].[Course]
	SET Crs_duration = @Crs_duration WHERE Crs_id = @Crs_id;
END;

---------------------------------Delete Course--------------------------------------------------------
CREATE OR ALTER PROC DeleteCourse
	@Crs_id INT
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM [dbo].[Course]  WHERE Crs_id = @Crs_id)
	BEGIN
		SELECT 'Course does not Exists' AS ResultMessage
		RETURN
	END
	
	DELETE FROM [dbo].[Course] WHERE Crs_id = @Crs_id;
END;

---------------------------------Get Number Of Courses Per Student--------------------------------------------------------
CREATE PROCEDURE GetNumberOfCoursesPerStudent
AS
BEGIN
    SELECT
        s.St_id AS Student_ID,
        COALESCE(COUNT(sc.Crs_id), 0) AS Number_Of_Courses
    FROM
        Student s
    LEFT JOIN
        Student_Courses sc ON s.St_id = sc.Std_id
    GROUP BY
        s.St_id;
END;

-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------