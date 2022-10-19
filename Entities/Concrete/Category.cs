using Core.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category :IEntity
    {
        public int CategoryId { get; set; }

        public string Goods { get; set; }
        
    }
}
