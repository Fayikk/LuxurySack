using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DtoS;

namespace DataAccess.Concrete
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, LuxurySacksContext>, IBrandDal
    {
        public List<BrandDetailDto> BrandDetails()
        {
            using (LuxurySacksContext context = new LuxurySacksContext())
            {
                var result = from b in context.Brands
                             join p in context.Products
                             on b.BrandId equals p.BrandId
                             select new BrandDetailDto
                             {
                                 BrandId = b.BrandId,
                                 Brands = b.Brands,
                                 Description = p.ProductName,
                                 Price = p.Price,
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 Size = p.Size
                             };
                return result.ToList();
            }
        }
    }
}
