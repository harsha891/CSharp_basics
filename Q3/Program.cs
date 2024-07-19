using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cinema selection with validation
            String anotherCustomer = "Y";
            do
            {
                Console.WriteLine("Welcome to our Multiplex");
                Console.WriteLine("We are presently showing:");
                Console.WriteLine("\t1. Rush (15)\n\t2. How I Live Now (15)\n\t3. Thor: The Dark World (12A)\n\t4. Filth (18)\n\t5. Planes (U)");
                int movie, age;
                do
                {
                    Console.Write("Enter the number of the film you wish to see: ");
                    movie = int.Parse(Console.ReadLine()); // input must be from 1 to 5
                    Console.WriteLine((movie < 1 || movie > 5) ? "Film number is invalid.." : "");
                } while (movie < 1 || movie > 5);

                do
                {
                    Console.Write("Enter your age: ");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine((age < 0) ? "invalid age... Age must be positive" : "");
                } while (age < 0);

                switch (movie)
                {
                    case 1:
                        if (age >= 15)
                            Console.WriteLine("Enjoy the film");
                        else
                            Console.WriteLine("Access denied – you are too young");
                        break;
                    case 2:
                        if (age >= 15)
                            Console.WriteLine("Enjoy the film");
                        else
                            Console.WriteLine("Access denied – you are too young");
                        break;
                    case 3:
                        if (age >= 12)
                            Console.WriteLine("Enjoy the film");
                        else
                            Console.WriteLine("Access denied – you are too young");
                        break;
                    case 4:
                        if (age >= 18)
                            Console.WriteLine("Enjoy the film");
                        else
                            Console.WriteLine("Access denied – you are too young");
                        break;
                    case 5:
                        if (age >= 4)
                            Console.WriteLine("Enjoy the film");
                        else
                            Console.WriteLine("Access denied – you are too young");
                        break;
                    default:
                        Console.WriteLine("Invalid Movie Selection");
                        break;
                }
                Console.Write("\nAnother Customer? Y or N : ");
                anotherCustomer = Console.ReadLine().ToUpper();

            } while (anotherCustomer.ToUpper().Equals("Y"));

        }
    }
}
