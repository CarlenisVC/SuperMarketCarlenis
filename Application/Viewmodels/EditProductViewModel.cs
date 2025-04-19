using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Viewmodels
{
    public class EditProductViewModel
    {
        public string OriginalName { get; set; } 
        public string Name { get; set; }          
        public string Description { get; set; }
        public double Price { get; set; }
        public int ProductType { get; set; }
    }
}

