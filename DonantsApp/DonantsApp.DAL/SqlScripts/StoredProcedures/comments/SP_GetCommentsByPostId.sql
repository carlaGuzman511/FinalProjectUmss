CREATE PROCEDURE SP_GetCommentsByPostId
@PostId INT
AS
SELECT 
	comment.Id,
	comment.Description,
	comment.DateAdded,
	comment.DateChanged,
	comment.PostId
FROM dbo.Comment comment
INNER JOIN dbo.Post post
ON post.Id = comment.PostId
WHERE 
post.Id = @PostId