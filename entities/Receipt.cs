using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferre_Linq.entities
{
    public class Receipt
    {
        public int NumReceipt { get; set; }
        public DateOnly Date { get; set; }
        public int ClientId { get; set; }
        public int TotalReceipt { get; set; }
        public List<int> ListProducts { get; set; }
    }
}