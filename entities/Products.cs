using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferre_Linq.entities
{
    public class Products
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Cantity { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
    }
}