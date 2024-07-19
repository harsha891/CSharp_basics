using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exam scores and degree classifications
            Console.Write("Enter candidate marks: ");
            int score = int.Parse(Console.ReadLine()); // must be in rnage of 0 to 100%

            if (score < 0 || score > 100)
                Console.WriteLine("Invalid Score");
            else if (score < 35)
                Console.WriteLine("Candidate Failed");
            else if (score < 40)
                Console.WriteLine("Candiate can be \"compensated\"");
            else if (score < 50)
                Console.WriteLine("Candidate passed in third class degree - III");
            else if (score < 60)
                Console.WriteLine("Candidate passed in lower second class degree - II(ii)");
            else if(score < 70)
                Console.WriteLine("Candidate passed in upper second class degree - II(i)");
            else Console.WriteLine("Candidate passed in lower second class degree - I");
        }
    }
}
