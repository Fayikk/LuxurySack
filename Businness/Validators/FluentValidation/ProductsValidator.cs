using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Validators.FluentValidation
{
    public class ProductsValidator : AbstractValidator<Product>
    {
        public ProductsValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün adı 'A' ile başlamalıdır");
        }
        private bool StartWithA(string arg)//Burada ise metodlarımzı ve validator'larımızı biz oluşturuyoruz.
        {
            return arg.StartsWith("A");//Değer true dönecektir.Eğer false dönerse yukarıdaki validator patlayacaktır.
        }
    }
}
