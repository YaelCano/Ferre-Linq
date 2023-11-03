using Ferre_Linq.entities;

internal class Program
{
    private static void Main(string[] args)
    {
        LinQ funciones = new();
        bool bander = false;

        while (bander == false)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║      MENÚ DE LA FERRETERÍA       ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("| 1. List Inventory Products       |");
            Console.WriteLine("| 2. List Products  To be Finished |");
            Console.WriteLine("| 3. List products you should buy  |");
            Console.WriteLine("| 4. List Recipts January/2023     |");
            Console.WriteLine("| 5. List Products from a receipt  |");
            Console.WriteLine("| 6. Calculate the total Inventory |");
            Console.WriteLine("| 7. Exit                          |");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.WriteLine($"Elige un opcion: ");
            var opcion = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    funciones.ListProducts();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    funciones.ListEndProducts();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    funciones.ListProductsBuy();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    funciones.ReceiptsJanuary();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    funciones.GetProductsFromReceipts();
                    Console.ReadKey();
                    break;
                case "6":
                    Console.Clear();
                    funciones.CalculateTotalPriceStock();
                    Console.ReadKey();
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Gracias.....");
                    bander = true;
                    break;
                default:
                    Console.WriteLine("No haz seleccionado ninguna de las opciones.");
                    Console.WriteLine($"Adios y vuelve pronto :....");
                    bander = true;
                    break;
            }
        }
    }
}