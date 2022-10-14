using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DtoS
{
    public class BrandDetailDto : IDto
    {
        public int BrandId { get; set; }
        public string Brands { get; set; }

        public int ProductId { get; set; }
        //public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public decimal Size { get; set; }
        public string Description { get; set; }
    }
}
