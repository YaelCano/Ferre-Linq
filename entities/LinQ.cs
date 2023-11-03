using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferre_Linq.entities
{
    public class LinQ
    {
        List<Products> Products = new(){
            new(){Id = 1, Name = "Tornillos", Cantity = 30, UnitPrice = 400, MinStock = 40, MaxStock = 300},
            new(){Id = 2, Name = "Clavos", Cantity = 90, UnitPrice = 100, MinStock = 40, MaxStock = 300},
            new(){Id = 3, Name = "Bisagras", Cantity = 65, UnitPrice = 1000, MinStock = 40, MaxStock = 300},
            new(){Id = 4, Name = "Pinturas", Cantity = 35, UnitPrice = 2000, MinStock = 40, MaxStock = 300},
            new(){Id = 5, Name = "EstucoBlanco", Cantity = 120, UnitPrice = 400, MinStock = 40, MaxStock = 300}
            
        };
        List<Receipt> Receipts = new(){
            new(){
                NumReceipt = 123,
                DateOnly = new DateOnly(2022,03,29),
                ClientId = 1,
                TotalReceipt = 5000
            },
        new(){NumReceipt}
        }
    }
}