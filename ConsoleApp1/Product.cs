using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public Product(string name,double price)
        {
             Name = name;
            Price = price;
        }

        public string Name;
        public double Price;
        public int Count;

        public void Detail()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Price: {Price}");
            sb.AppendLine($"Count: {Count}");

            Console.WriteLine(sb);
        }

        

        public void Discount(int discount)
        {

            Console.WriteLine( "Discount:");
            Console.WriteLine(Price - Price*discount/100);
        }
        
    }
}
