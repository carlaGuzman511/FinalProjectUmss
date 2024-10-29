CREATE PROCEDURE SP_GetDonationTypes
@DonationTypeId INT NULL
AS
SELECT 
	donationType.Id,
	donationType.Description
FROM dbo.Donation donationType
WHERE 
@DonationTypeId IS NOT NULL AND donationType.Id = @DonationTypeId
OR
@DonationTypeId IS NULL