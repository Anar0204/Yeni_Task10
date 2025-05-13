using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book:Product
    {
        public Book(string genre,string name,double price):base(name,price)
        {
             Genre = genre;
        }
        public string Genre;

    }
}
