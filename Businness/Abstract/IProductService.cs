using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface IProductService
    {

        IDataResult<List<Product>> GetAll();
        IResult add(Product product);
        //Delete
        IResult delete(Product product);
        //Update
        IResult Update(Product product);
        IResult TransactionalOperation(Product product);

        IDataResult<List<Product>> GetById(int Id);


    }
}
