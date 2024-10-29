CREATE PROCEDURE dbo.SP_UpdatePost
	@PostId INT,
	@Image VARCHAR(MAX) = NULL,
	@Description VARCHAR(2500),
	@Title VARCHAR(150),
	@AccountId INT,
	@PostTypeId INT,
	@DonationTypeId INT = NULL

AS

UPDATE dbo.Post
SET
	PostDate = GETDATE(), 
	StatusId = 1, 
	Image = @Image, 
	Title = @Title,
	Description = @Description, 
	AccountId = @AccountId, 
	PostTypeId = @PostTypeId, 
	DonationTypeId = @DonationTypeId
WHERE Id = @PostId

SELECT SCOPE_IDENTITY()
