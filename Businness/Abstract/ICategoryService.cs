using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DtoS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IResult add(Category category);
        //Delete
        IResult delete(Category category);
        //Update
        IResult Update(Category category);

        IDataResult<List<CategoryDeatilDto>> GetDetails();
        //IDataResult<List<Category>> GetById(int Id);
    }
}
