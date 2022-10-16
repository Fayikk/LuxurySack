using Businness.Abstract;
using Businness.Constant;
using Businness.Validators.FluentValidation;
using Core.Aspects.AutoFac.Logging;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal=categoryDal;
        }

        [ValidationAspect(typeof(CategoriesValidator))]
        [CacheRemoveAspect("ICategorSerice.Get")]

        public IResult add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.Added);
        }

        public IResult delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.Deleted);
        }

        [CacheAspect]
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.Listed);
        }
        //[LogAspect(typeof(FileLogger))]
        public IDataResult<List<CategoryDeatilDto>> GetDetails()
        {
            return new SuccessDataResult<List<CategoryDeatilDto>>(_categoryDal.GetBrandDetailDtos(), Messages.Listed);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.Updated);
        }
    }
}
