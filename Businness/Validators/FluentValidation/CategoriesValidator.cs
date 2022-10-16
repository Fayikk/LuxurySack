using Entities.Concrete;
using FluentValidation;

namespace Businness.Validators.FluentValidation
{
    public class CategoriesValidator : AbstractValidator<Category>
    {
        public CategoriesValidator()
        {
            RuleFor(c => c.Goods).NotEmpty();
            RuleFor(c=>c.BrandId).NotEmpty();
            RuleFor(c => c.BrandId).Must(deneme).WithMessage("Marka Id'sini kontrol ediniz");

        }

        private bool deneme(Category category,int deneme)
        {
            
            for (int i=1 ; i <= category.BrandId; i++)
            {
                if (deneme==category.BrandId)
                {
                    Console.WriteLine("Marka Id'sini kontrol ediniz");
                }
            }
            return true;
        }
    }
}
