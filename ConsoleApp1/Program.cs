namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("kitabin sayini daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());

            Book[] books = new Book[count];

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Genre ,Ad ve qiymeti sira ile daxil edin "); 
                Book book = new(Console.ReadLine(),  Console.ReadLine(),  Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine( " sayi daxil edin ");
                book.Count = Convert.ToInt32(Console.ReadLine());


                books[i] = book;
            }

            foreach(Book book in books)
            {
                book.Discount(10);

                Console.WriteLine($"kitab adi:" +book.Name);
                Console.WriteLine($"kitab qiymeti:" + book.Price);
                Console.WriteLine($"kitab janri:" + book.Genre);
                Console.WriteLine($"kitab sayi:" + book.Count);
            }

            
        }
    }
}
