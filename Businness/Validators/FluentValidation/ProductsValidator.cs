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

        }
    }
}
