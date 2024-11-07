CREATE PROCEDURE SP_DeleteCommentById
	@CommentId INT
AS
DELETE comment
FROM dbo.Comment comment
INNER JOIN dbo.Post post
ON comment.PostId = post.Id
WHERE comment.Id = @CommentId