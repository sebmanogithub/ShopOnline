using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class ProductCategoryDto
    {
        public ProductCategoryDto(int id, string name, string iconCss)
        {
            Id = id;
            Name = name;
            IconCSS = iconCss;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IconCSS { get; set; }
    }
}
