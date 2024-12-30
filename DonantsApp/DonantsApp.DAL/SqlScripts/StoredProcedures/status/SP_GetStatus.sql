CREATE PROCEDURE SP_GetStatus
@StatusId INT NULL
AS
SELECT 
	status.Description
FROM dbo.Status status
WHERE 
@StatusId IS NOT NULL AND status.Id = @StatusId
OR
@StatusId IS NULL