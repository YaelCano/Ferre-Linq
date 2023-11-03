using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
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
                Date = new DateOnly(2022,03,29),
                ClientId = 1,
                TotalReceipt = 5000
            },
        new(){NumReceipt = 234, Date = new DateOnly(2023,02,12), ClientId = 2,TotalReceipt = 2000},
        new(){NumReceipt = 320, Date = new DateOnly(2023,06,12), ClientId = 2,TotalReceipt = 2000},
        new(){NumReceipt = 456, Date = new DateOnly(2023,07,20), ClientId = 2,TotalReceipt = 2000},
        new(){NumReceipt = 456, Date = new DateOnly(2023,08,12), ClientId = 2,TotalReceipt = 2000},
        new(){NumReceipt = 540, Date = new DateOnly(2023,01,15), ClientId = 2,TotalReceipt = 2000},
        new(){NumReceipt = 320, Date = new DateOnly(2023,04,11), ClientId = 2,TotalReceipt = 2000},
        new(){NumReceipt = 540, Date = new DateOnly(2023,06,12), ClientId = 2,TotalReceipt = 2000},
        };

        List<ReceiptDetail> Details = new(){
            new(){Id = 1, NumReceipt = 123, ProductId = 1, Cantity = 2},
            new(){Id = 2, NumReceipt = 123, ProductId = 2, Cantity = 3},
            new(){Id = 3, NumReceipt = 123, ProductId = 3, Cantity = 1},
            new(){Id = 4, NumReceipt = 123, ProductId = 4, Cantity = 4},
            new(){Id = 5, NumReceipt = 234, ProductId = 1, Cantity = 3}
        };
    }
}