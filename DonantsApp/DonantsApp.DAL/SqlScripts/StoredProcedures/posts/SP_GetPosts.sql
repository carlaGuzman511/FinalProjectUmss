ALTER PROCEDURE SP_GetPosts
@AccountId INT = NULL,
@PostId INT = NULL

AS

SELECT 
	post.Id,
	post.Title,
	post.Description, 
	post.Image Image, 
	post.PostDate PostDate,
	person.FirstName,
	person.Id,
	person.LastName,
	person.PhoneNumber PhoneNumber, 
	person.Image,
	person.BloodTypeId,
	donationType.Id DonationTypeId,
	donationType.Description,
	postType.Id PostTypeId,
	postType.Description,
	status.Id StatusId,
	status.Description

FROM dbo.Post post
INNER JOIN dbo.Account account
ON account.Id = post.AccountId
INNER JOIN dbo.Person person
ON account.PersonId = person.Id
LEFT JOIN dbo.Status status
ON post.StatusId = status.Id
LEFT JOIN dbo.DonationType donationType
ON post.DonationTypeId = donationType.Id
LEFT JOIN dbo.PostType postType
ON post.PostTypeId = postType.Id
WHERE 
(@AccountId IS NOT NULL AND post.AccountId = @AccountId
OR
@AccountId IS NULL)
AND
(@PostId IS NOT NULL AND post.Id = @PostId
OR
@PostId IS NULL)
