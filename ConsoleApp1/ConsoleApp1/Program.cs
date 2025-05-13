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



                books[i] = book;
            }

            
            int operation;
            bool check = true;

            do
            {
                Console.WriteLine( "emeliyyati daxil edin ");
                Console.WriteLine("1.Kitablari qiymete gore filterle 2.Butun kitablari goster 0. Proqrami bagla");
                operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 0:
                        check = false;
                        break;
                    case 1:

                        for (int i = 0; i < books.Length; i++)
                        {
                            for (int j = i + 1; j < books.Length; j++)
                            {
                                if (books[i].Price < books[j].Price)
                                {

                                    Book book = books[i];
                                    books[i] = books[j];
                                    books[j] = book;
                                }
                            }
                        }
                        foreach (Book book in books)
                        {
                            book.Discount(10);

                            Console.WriteLine($"kitab adi:" + book.Name);
                            Console.WriteLine($"kitab qiymeti:" + book.Price);
                            Console.WriteLine($"kitab janri:" + book.Genre);
                            Console.WriteLine($"kitab sayi:" + book.Count);
                        }
                        break;

                        
                    case 2:
                        foreach (Book book in books)
                        {
                            book.Discount(10);

                            Console.WriteLine($"kitab adi:" + book.Name);
                            Console.WriteLine($"kitab qiymeti:" + book.Price);
                            Console.WriteLine($"kitab janri:" + book.Genre);
                            Console.WriteLine($"kitab sayi:" + book.Count);
                        }
                        break;
                    default:
                        Console.WriteLine( "yanlish emeliyyat");
                        break;


                }
            } while (check);



        }
    }
}
