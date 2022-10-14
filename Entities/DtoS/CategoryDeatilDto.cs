using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DtoS
{
    public class CategoryDeatilDto : IDto
    {
        //category ve brand class'ı kullanılacaktır.
        public int CategoryId { get; set; }

        public string Goods { get; set; }
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public string Brands { get; set; }
        //public int CategoryId { get; set; }

    }
}
