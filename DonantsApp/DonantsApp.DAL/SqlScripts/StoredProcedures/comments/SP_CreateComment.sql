CREATE PROCEDURE SP_CreateComment
	@PostId INT,
	@Description VARCHAR(2500)
AS
INSERT INTO dbo.Comment
(
	PostId,
	Description,
	DateAdded,
	DateChanged
) 
VALUES
(
	@PostId,
	@Description,
	GETDATE(),
	NULL
) 

SELECT SCOPE_IDENTITY()
