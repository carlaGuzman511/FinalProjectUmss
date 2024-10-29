ALTER PROCEDURE SP_DeleteComment
	@CommentId INT
AS
DELETE comment
FROM dbo.Comment comment
INNER JOIN dbo.Post post
ON comment.PostId = post.Id
WHERE comment.Id = @CommentId