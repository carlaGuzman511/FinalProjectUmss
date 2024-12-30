CREATE PROCEDURE dbo.SP_DeletePost
@PostId INT
AS

DELETE FROM dbo.Comment
WHERE PostId = @PostId

DELETE FROM dbo.Post
WHERE Id = @PostId