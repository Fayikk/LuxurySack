using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DtoS;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        List<CategoryDeatilDto> GetBrandDetailDtos();

    }
}
