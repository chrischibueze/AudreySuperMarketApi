using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudreySuperMarket.Models.Dtos
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public string IconCSS { get; set; }
        public List<string> Products { get; set; }
    }
}
