using Core.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
    public class Brand :IEntity
    {
        public int BrandId { get; set; }
        public string Brands { get; set; }

        public int CategoryId { get; set; }
    }
}
