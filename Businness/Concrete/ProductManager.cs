using Businness.Abstract;
//using Businness.BusinessAspects.Autofac;
using Businness.Constant;
using Businness.Validators.FluentValidation;
using Core.Aspects.AutoFac.Performance;
using Core.Aspects.AutoFac.Transaction;
using Core.Aspects.Validation;
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

        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(ProductsValidator))]
        [PerformanceAspect(5)]//bu anotation asıl kullanım amacı overwatch üzerinden eğer bu metodun çalışması 5 sn'yi geçerse
        //bir şekilde etkileşim kurmak için kullanılmaktadır.
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

        public IDataResult<List<Product>> GetById(int Id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.BrandId == Id), Messages.SuccessMessages);
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Product product)
        {
            _productDal.Update(product);
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.Updated);
        }
    }
}
