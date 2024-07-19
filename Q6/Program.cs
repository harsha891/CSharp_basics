using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vowels counting
            int vowelCount = 0;

            StreamReader rdr;
            rdr = new StreamReader("words.txt"); // wors.txt file in -- Q6\bin\Debug
            Console.WriteLine("Words in words.txt file : ");
            while (rdr.EndOfStream == false)
            {
                String word = rdr.ReadLine().ToLower();
                Console.WriteLine("\t" + word);
                int tempVowelCount = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                        tempVowelCount++;
                }
                vowelCount = tempVowelCount > vowelCount ? tempVowelCount : vowelCount;
            }
            Console.WriteLine("\nThe largest number of vowels in any one word is: " + vowelCount);
            rdr.Close();
        }
    }
}
