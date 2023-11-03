using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferre_Linq.entities
{
    public class ReceiptDetail
    {
        public int Id { get; set; }
        public int NumReceipt { get; set; }
        public int ProductId { get; set; }
        public int Cantity { get; set; }
        public int Price { get; set; }
    }
}