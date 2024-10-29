using DonantsApp.Models;
using FluentValidation;

namespace DonantsApp.Services.Validators
{
    internal class PostValidator : AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleSet("Create", () =>
            {
                RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is required");
                RuleFor(x => x.Description)
                    .NotEmpty()
                    .WithMessage("Description is required");
                RuleFor(x => x.DonationTypeId)
                    .NotEmpty()
                    .WithMessage("Donation Type Id is required");
                //.MustAsync((donationTypeId, token) => this.DonationTypeIdExists(donationTypeId))
                //.WithMessage("Donation Type does not exist");
                RuleFor(x => x.PostTypeId)
                    .NotEmpty()
                    .WithMessage("Post Type Id is required");
                //.MustAsync((postTypeId, token) => this.PostTypeIdExists(postTypeId))
                //.WithMessage("Post Type does not exist");
                RuleFor(x => x.AccountId)
                    .NotEmpty()
                    .WithMessage("Account Id is required");
                //.MustAsync((accountId, token) => this.AccountIdExists(accountId))
                //.WithMessage("Account Type does not exist");
            });

            RuleSet("Update", () =>
            {
            });
        }

        //private async Task<bool> DonationTypeIdExists(int donationTypeId)
        //{
        //    DonationType? donationType = await this.donationTypeRepository.GetDonationTypeAsync(donationTypeId);
        //    return donationType != null;
        //}
        //private async Task<bool> PostTypeIdExists(int postTypeId)
        //{
        //    PostType? postType = await this.postTypeRepository.GetPostTypeAsync(postTypeId);
        //    return postType != null;
        //}
        //private async Task<bool> AccountIdExists(int accountId)
        //{
        //    return false;
        //}
    }
}
