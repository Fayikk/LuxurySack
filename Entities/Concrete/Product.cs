using Core.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;



namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }

        public int BrandId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public decimal Size { get; set; }
        public string Description { get; set; }
      


    }
}
