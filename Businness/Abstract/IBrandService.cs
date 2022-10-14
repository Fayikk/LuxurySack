using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IResult add(Brand brand);
        //Delete
        IResult delete(Brand brand);
        //Update
        IResult Update(Brand brand);
    }
}
