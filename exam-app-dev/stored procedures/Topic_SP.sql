-----------------------------Stored Procedre For Topics---------------

-------------------------------Insert Topic-------------------------------

CREATE PROCEDURE InsertTopic
    @Topic_name VARCHAR(255)
AS
BEGIN
    -- Insert the new topic
    INSERT INTO Topic (Topic_name)
    VALUES (@Topic_name);

    PRINT 'Topic inserted successfully.';
END;
EXEC InsertTopic @Topic_name = 'Olatest';

----------------------------------Select Topics-------------------------------------------------------
CREATE PROCEDURE SelectTopics
AS
BEGIN
    -- Select all columns from the Topic table
    SELECT * FROM	Topic;
END;

--------------------------------------------Update Topic---------------------------------------------
CREATE PROCEDURE UpdateTopic
    @Topic_id INT,
    @NewTopic_name VARCHAR(255)
AS
BEGIN
    -- Check if the topic exists before updating
    IF EXISTS (SELECT 1 FROM Topic WHERE Topic_id = @Topic_id)
    BEGIN
        -- Update the topic name for the specified Topic_id
        UPDATE Topic
        SET Topic_name = @NewTopic_name
        WHERE Topic_id = @Topic_id;
        
        PRINT 'Topic updated successfully.';
    END
    ELSE
    BEGIN
        -- Handle the case where the topic does not exist
        PRINT 'Error: The specified topic does not exist.';
    END
END;

----------------------------------Delete Topic-------------------------------------------------------
CREATE PROCEDURE DeleteTopic 
    @Topic_id INT
AS
BEGIN
    -- Temporarily disable the foreign key constraint
    ALTER TABLE Course
        DROP CONSTRAINT FK_Course_Topic;

    -- Delete the topic if it exists
    IF EXISTS (SELECT 1 FROM Topic WHERE Topic_id = @Topic_id)
    BEGIN
        DELETE FROM Topic
        WHERE Topic_id = @Topic_id;
        
        PRINT 'Topic deleted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Error: The specified topic does not exist.';
    END

    -- Reapply the foreign key constraint
    ALTER TABLE Course
        ADD CONSTRAINT FK_Course_Topic FOREIGN KEY (Topic_id)
        REFERENCES Topic(Topic_id);
END;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------