CREATE PROCEDURE SP_GetBloodTypes
@BloodTypeId INT NULL = NULL
AS
SELECT 
	bloodType.Id,
	bloodType.Description
FROM dbo.BloodType bloodType
WHERE 
@BloodTypeId IS NOT NULL AND bloodType.Id = @BloodTypeId
OR
@BloodTypeId IS NULL