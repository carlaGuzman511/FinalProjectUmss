ALTER PROCEDURE SP_CreatePost
	@Image VARCHAR(MAX) = NULL,
	@Description VARCHAR(2500),
	@Title VARCHAR(150),
	@AccountId INT,
	@PostTypeId INT,
	@DonationTypeId INT = NULL

AS

INSERT INTO dbo.Post(
	PostDate, 
	StatusId, 
	Image, 
	Description, 
	Title,
	AccountId, 
	PostTypeId, 
	DonationTypeId)

VALUES(
	GETDATE(), 
	1, --Active
	@Image, 
	@Description, 
	@Title,
	@AccountId, 
	@PostTypeId, 
	@DonationTypeId)

SELECT SCOPE_IDENTITY()
