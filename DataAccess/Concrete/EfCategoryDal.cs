using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DtoS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, LuxurySacksContext>, ICategoryDal
    {



        public List<CategoryDeatilDto> GetBrandDetailDtos()
        {
            using (LuxurySacksContext context = new LuxurySacksContext())
            {
                var result = from c in context.Categories
                             join b in context.Brands
                             on c.CategoryId equals b.CategoryId
                             select new CategoryDeatilDto
                             {
                                 BrandId = b.BrandId
                                 ,
                                 Brands = b.Brands
                                 ,
                                 CategoryId = c.CategoryId
                                 ,
                                 Goods = b.Brands,
                                 ProductId = b.BrandId
                             };
                return result.ToList();
            }
        }
    }
}
