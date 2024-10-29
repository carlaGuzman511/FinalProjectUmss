CREATE PROCEDURE SP_CreateComment
	@PostId INT,
	@Description
AS
INSERT INTO dbo.Comment
(
	@PostId,
	@Description
) 
SELECT SCOPE_IDENTITY()