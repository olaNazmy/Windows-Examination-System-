-----------------Stored Procedre For Track---------------

-------------------------------Insert Course In Track----------------------------

CREATE OR ALTER PROC InsertCourseInTrack
	@Tr_id INT,
	@Crs_id	  INT
AS
BEGIN
		IF EXISTS (SELECT 1 FROM [dbo].[Crs_Track] 
					WHERE Crs_id = @Crs_id AND Tr_id = @Tr_id)
	BEGIN
		SELECT 'Course Exists In DB' AS ResultMessage
		RETURN
	END

	INSERT INTO [dbo].[Crs_Track]
	VALUES(@Crs_id, @Tr_id)
END;

------------------------------------Delete Track Course-----------------------------------------------------
CREATE OR ALTER PROC DeleteTrackCourse
	@Tr_id INT,
	@Crs_id	  INT
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM [dbo].[Course]  WHERE Crs_id = @Crs_id)
	BEGIN
		SELECT 'Course does not Exists' AS ResultMessage
		RETURN
	END
	
	DELETE FROM [dbo].[Crs_Track] WHERE Crs_id = @Crs_id And [Tr_id] = @Tr_id;
END;

-------------------------------------display All Courses In Track-----------------------------
CREATE OR ALTER PROC displayAllCoursesInTrack
	@Tr_id INT
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM [dbo].[Track] WHERE Tr_id = @Tr_id)
	BEGIN
		SELECT 'Track does not Exists' AS ResultMessage
		RETURN
	END
	
	SELECT T.Tr_name, Crs_name, Crs_duration FROM Track T
		JOIN Crs_Track
		ON T.Tr_id = Crs_Track.Tr_id
		JOIN Course
		ON Crs_Track.Crs_id = Course.Crs_id
		WHERE T.Tr_id = @Tr_id;
END;
-----------------------------------------------------------------------------------------
