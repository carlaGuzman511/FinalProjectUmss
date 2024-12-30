CREATE PROCEDURE SP_GetDonationTypes
@DonationTypeId INT NULL = NULL
AS
SELECT 
	donationType.Id,
	donationType.Description
FROM dbo.DonationType donationType
WHERE 
@DonationTypeId IS NOT NULL AND donationType.Id = @DonationTypeId
OR
@DonationTypeId IS NULL
