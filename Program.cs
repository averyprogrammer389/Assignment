using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                stringBuilder.Append(rand.Next(1, 6));
            }

            // string generatedNum = stringBuilder.ToString();


            string generatedNum = "1234";
            //string guess = "4233";
            string guess = string.Empty;

            int counter = 0;
            string output = string.Empty;
            while (counter < 10)
            {
                Console.WriteLine("Please enter a number guess");
                guess = Console.ReadLine();
                for (int k = 0; k < generatedNum.Length; k++)
                {
                    if (generatedNum[k] == guess[k])
                    {
                        output += "+";
                        continue;
                    }
                    else if (generatedNum[k] != guess[k] && guess.Contains(generatedNum[k]))
                    {
                        output += "-";
                        continue;
                    }

                    if (output.Count(x => x == '+') == 4)
                    {
                        Console.WriteLine("Number Guessed");
                        break;
                    }

                    continue;


                }
                counter++;
                if(counter==10){
                    Console.WriteLine("You have lost");
            }

        }
    }
}

