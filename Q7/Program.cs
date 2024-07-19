using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static int ReadNumber(string msg, int min, int max) {
            int movie = 0;
            do
            {
                Console.Write(msg);
                movie = int.Parse(Console.ReadLine()); // input must be from 1 to 5
                Console.WriteLine((movie < 1 || movie > 5) ? "Film number is invalid.." : "");
            } while (movie < 1 || movie > 5);

            return movie; 
        }

        static Boolean validateFilmRating(string film)
        {
            if(film.Contains("(15)") || film.Contains("(12)") || film.Contains("(18)") || film.Contains("(U)") || film.Contains("(12A)"))
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            //Cinema entry with improvements
            String anotherCustomer = "Y";
            
            Console.WriteLine("Welcome to our Multiplex");

            string[] films = new string[5];
            for(int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write("Enter name for film for number " + (i + 1) + " : ");
                    films[i] = Console.ReadLine();
                    if (validateFilmRating(films[i]))
                        break;

                    Console.Write("Invalid film name... Re-");
                } while (true);
            }

            do
            {
                Console.WriteLine("We are presently showing:");
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine("\t" + (i+1) + ". " + films[i]);
                }

                int movie = ReadNumber("Enter the number of the film you wish to see: ", 1, 5);
                int age;
                do
                {
                    Console.Write("Enter your age: ");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine((age < 0) ? "invalid age... Age must be positive" : "");
                } while (age < 0);

                if (films[movie - 1].EndsWith("(15)"))
                {
                    if (age >= 15)
                        Console.WriteLine("Enjoy the film");
                    else
                        Console.WriteLine("Access denied – you are too young");
                }
                else if (films[movie - 1].EndsWith("(12A)"))
                {
                    if (age >= 12)
                        Console.WriteLine("Enjoy the film");
                    else
                        Console.WriteLine("Access denied – you are too young");
                }
                else if (films[movie - 1].EndsWith("(18)"))
                {
                    if (age >= 18)
                        Console.WriteLine("Enjoy the film");
                    else
                        Console.WriteLine("Access denied – you are too young");
                }
                else if (films[movie - 1].EndsWith("(U)"))
                {
                    if (age >= 4)
                        Console.WriteLine("Enjoy the film");
                    else
                        Console.WriteLine("Access denied – you are too young");
                }
            
                Console.Write("\nAnother Customer? Y or N : ");
                anotherCustomer = Console.ReadLine().ToUpper();

            } while (anotherCustomer.ToUpper().Equals("Y"));

        }
    }
}
