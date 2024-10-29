CREATE PROCEDURE SP_UpdateComment
	@PostId INT,
	@Description VARCHAR(2000),
	@CommentId INT
AS
UPDATE comment
SET
	comment.Description = @Description, 
	comment.PostId = @PostId
FROM dbo.Comment comment
INNER JOIN dbo.Post post
ON post.Id = comment.PostId
WHERE comment.Id = @CommentId