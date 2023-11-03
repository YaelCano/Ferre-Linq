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
        public void ListProducts()
        {
            Products.ForEach(x => Console.WriteLine($"Name: {x.Name}, Id: {x.Id}, Cantity: {x.Cantity}, UnitPrice: {x.UnitPrice}"));
        }
        public void ListEndProducts()
        {
            var FnProduct = (from j in Products where j.Cantity < j.MinStock select j).ToList();
            Console.WriteLine($"The products that are close to Be finished are:");
            FnProduct.ForEach(J => Console.WriteLine($"{J.Name}: Cantity: {J.Cantity}, MinStock: {J.MinStock}"));
        }

        public void ListProductsBuy()
        {
            var ProductsTobuy = (from p in Products where p.Cantity < p.MinStock select p).ToList();
            ProductsTobuy.ForEach(M => Console.WriteLine($"The {M.Name} are close to Be Finished (there are only {M.Cantity}), you should {M.MaxStock - M.Cantity} to rach the maximun stock"));
        }
        public void ReceiptsJanuary()
        {
            var ReceiptsJan = (from d in Receipts where d.Date.Month == 01 && d.Date.Year == 2023 select d).ToList();
            foreach (var item in ReceiptsJan)
            {
                Console.WriteLine($"{(ReceiptsJan.IndexOf(item) + 1)}. NumReceipt: {item.NumReceipt}, TotalReceipt: {item.TotalReceipt}, Date: {item.Date.Day}/{item.Date.Month}/{item.Date.Year}");
            }
        }
        public void GetProductsFromReceipts()
        {
            Console.WriteLine("Put the number of the receipt: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var list = (from q in Details
                        join w in Receipts
                        on q.NumReceipt equals w.NumReceipt
                        join e in Products on q.ProductId equals e.Id
                        where w.NumReceipt == number
                        select new
                        {
                            ProductId = q.ProductId,
                            Cantity = q.Cantity,
                            receipt = q.NumReceipt,
                            Name = e.Name,
                            UnitPrice = e.UnitPrice,
                            Total = q.Cantity * e.UnitPrice
                        }).ToList();
            Console.WriteLine($"The products of the receipt number {number}");
            list.ForEach(z => Console.WriteLine($"{new { z.ProductId, z.Cantity, z.Name, z.UnitPrice, z.Total }}"));
        }
        public void CalculateTotalPriceStock()
        {
            int total = 0;
            foreach (var item in Products)
            {
                total += (item.Cantity * item.UnitPrice);
                Console.WriteLine($"The Total Price of {item.Name} in the inventory is: {item.UnitPrice * item.Cantity}");
            }
            Console.WriteLine($"The Total Price of all the inventory is: {total}");
        }
    }
}
