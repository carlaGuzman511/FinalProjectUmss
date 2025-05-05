CREATE PROCEDURE SP_GetPostTypes
@PostTypeId INT NULL = NULL
AS

SELECT 
	postType.Id,
	postType.Description
FROM dbo.PostType postType
WHERE 
@PostTypeId IS NOT NULL AND postType.Id = @PostTypeId
OR
@PostTypeId IS NULL