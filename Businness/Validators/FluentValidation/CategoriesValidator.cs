using Entities.Concrete;
using FluentValidation;

namespace Businness.Validators.FluentValidation
{
    public class CategoriesValidator : AbstractValidator<Category>
    {
        public CategoriesValidator()
        {
            RuleFor(c => c.Goods).NotEmpty();
        }
    }
}
