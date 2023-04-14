using System.Globalization;
using Vendas.entities;

namespace Vendas
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (resp == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsfee));
                }
                else if(resp == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine().ToString());
                    list.Add(new UsedProduct(name, price, manufacture));
                }
                else                
                {
                    list.Add(new Product(name, price));
                }

                

            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list)
            {
               Console.WriteLine(prod.priceTag()); 
            }
        }
    }
}
