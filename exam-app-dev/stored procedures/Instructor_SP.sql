--------------------------------Stored Procedure For Instructor ----------------------

-----------------------------------Insert New Instructor------------------------------------------------
CREATE PROCEDURE InsertInstructor
    @Ins_id INT,
    @Ins_Lname NCHAR(20),
    @Ins_Fname NCHAR(20),
    @Ins_BirthDate DATE,
    @Ins_Phone NCHAR(20),
    @Ins_Degree NVARCHAR(20),
    @User_id INT
AS
BEGIN

    INSERT INTO Instructor (Ins_id, Ins_Lname, Ins_Fname, Ins_BirthDate, Ins_Phone, Ins_Degree, User_id)
    VALUES (@Ins_id, @Ins_Lname, @Ins_Fname, @Ins_BirthDate, @Ins_Phone, @Ins_Degree, @User_id);
END;

---------------------------------------Update Instructor----------------------------------------------------
CREATE PROCEDURE UpdateInstructor
    @Ins_id INT,
    @NewIns_Lname NCHAR(20),
    @NewIns_Fname NCHAR(20),
    @NewIns_BirthDate DATE,
    @NewIns_Phone NCHAR(20),
    @NewIns_Degree NVARCHAR(20),
    @NewUser_id INT
AS
BEGIN
    UPDATE Instructor
    SET Ins_Lname = @NewIns_Lname,
        Ins_Fname = @NewIns_Fname,
        Ins_BirthDate = @NewIns_BirthDate,
        Ins_Phone = @NewIns_Phone,
        Ins_Degree = @NewIns_Degree,
        User_id = @NewUser_id
    WHERE Ins_id = @Ins_id;
END;

----------------------------------------Delete Instructor--------------------------------------------
CREATE PROCEDURE DeleteInstructor
    @Ins_id INT
AS
BEGIN
    DELETE FROM Instructor
    WHERE Ins_id = @Ins_id;
END;

----------------------------Get Instructors With Courses And Students Count----------------------
CREATE PROCEDURE GetInstructorsWithCoursesAndStudentsCount
AS
BEGIN
    SELECT
        CONCAT(i.Ins_Fname, ' ', i.Ins_Lname) AS Instructor_Name,
        c.Crs_name AS Course_Name,
        c.Crs_duration AS Course_Duration,
        COUNT(sc.Std_id) AS Number_Of_Students
    FROM
        Instructor i
    INNER JOIN
        Ins_Courses ic ON i.ins_id = ic.ins_id
    INNER JOIN
        Course c ON ic.Crs_id = c.Crs_id
    LEFT JOIN
        Student_Courses sc ON c.Crs_id = sc.Crs_id
    GROUP BY
        i.Ins_Id, i.Ins_Fname, i.Ins_Lname, c.Crs_id, c.Crs_name, c.Crs_duration;
END;

---------------------------------Insert Instructor Course--------------------------------------
CREATE PROCEDURE InsertInsCourse 
    @Ins_id INT,
    @Crs_id INT,
    @Evaluation NCHAR(10)
AS
BEGIN
    INSERT INTO Ins_Course (Ins_id, Crs_id, evaluation)
    VALUES (@Ins_id, @Crs_id, @Evaluation);
END;

---------------------------------------Update Instructor Course--------------------------------------------------
CREATE PROCEDURE UpdateInsCourse
    @Ins_id INT,
    @Crs_id INT,
    @NewEvaluation NCHAR(10)
AS
BEGIN
    UPDATE Ins_Course
    SET evaluation = @NewEvaluation
    WHERE Ins_id = @Ins_id AND Crs_id = @Crs_id;
END;
------------------------------------Delete Instructor Course-----------------------------------------------------
CREATE PROCEDURE DeleteInsCourse 
    @Ins_id INT,
    @Crs_id INT
AS
BEGIN
    DELETE FROM Ins_Course
    WHERE Ins_id = @Ins_id AND Crs_id = @Crs_id;
END;
-----------------------------------------------------------------------------------------
