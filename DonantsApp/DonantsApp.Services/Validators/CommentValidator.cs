using DonantsApp.Models;
using FluentValidation;

namespace DonantsApp.Services.Validators
{
    internal class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description is required");


            RuleSet("Create", () =>
            {

            });

            RuleSet("Update", () =>
            {
                RuleFor(x => x.PostId)
                .NotEmpty()
                .WithMessage("Post Id is required");
                //.MustAsync((postId, token) => this.PostIdExists(postId))
                //.WithMessage("Post Id does not exist");
            });
        }
    }
}
