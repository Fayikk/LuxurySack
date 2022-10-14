using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, LuxurySacksContext>, IBrandDal
    {
    }
}
