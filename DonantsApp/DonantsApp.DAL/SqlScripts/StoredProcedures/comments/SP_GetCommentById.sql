CREATE PROCEDURE SP_GetCommentById
@Id INT
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
comment.Id = @Id