using Businness.Abstract;
using Businness.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.Added);
        }

        public IResult delete(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
           return  new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.Listed);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.Updated);
        }
    }
}
