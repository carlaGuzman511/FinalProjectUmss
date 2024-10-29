CREATE PROCEDURE SP_GetBloodTypes
@BloodTypeId INT NULL
AS
SELECT 
	bloodType.Description
FROM dbo.BloodType bloodType
WHERE 
@BloodTypeId IS NOT NULL AND bloodType.Id = @BloodTypeId
OR
@BloodTypeId IS NULL