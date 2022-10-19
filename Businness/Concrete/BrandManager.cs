using Businness.Abstract;
using Businness.Constant;
using Core.Aspects.AutoFac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DtoS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(true,Messages.Added);
        }

        public IResult delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult( Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.Listed);
        }
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<BrandDetailDto>> GetBrandDetailDto()
        {
            return new SuccessDataResult<List<BrandDetailDto>>(_brandDal.BrandDetails(),Messages.Listed);
        }

        public IDataResult<List<Brand>> GetById(int Id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b => b.CategoryId == Id), Messages.SuccessMessages);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }
    }
}
