using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    class Magic8Ball
    {
        static void Main(string[] args)
        {
            /*
             * REQUIREMENTS:
             * 1) Ask the user for their yes/no question
             * 2) Respond with a random answer from your set (collection) of answers
             * 3) Set the program to loop based on user choice.
             */
            bool exit = false;
            do
            {
                Console.WriteLine("Ask me a question: ");
                if (Console.ReadLine().ToLower() == "what is the meaning of life?" || Console.ReadLine().ToLower() == "what is the meaning of life") //Gimmick saying the meaning of life is 42.
                {
                    Console.WriteLine("The answer you are looking for is 42.");
                    Console.WriteLine("Would you like to ask me another question? (Y/N):");
                    if (Console.ReadLine().ToLower() == "y" || Console.ReadLine().ToLower() == "yes")
                    {
                        Console.Clear();
                    }//end if
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        exit = true;
                    }//end else
                }//end if
                else
                {
                    string[] phrase = new string[20];
                    phrase[0] = "It is certain.";
                    phrase[1] = "It is decidedly so.";
                    phrase[2] = "Without a doubt.";
                    phrase[3] = "Yes - definitely.";
                    phrase[4] = "You may rely on it.";
                    phrase[5] = "As I see it, yes.";
                    phrase[6] = "Most likely.";
                    phrase[7] = "Outlook good.";
                    phrase[8] = "Yes.";
                    phrase[9] = "Signs point to yes.";
                    phrase[10] = "Reply hazy, try again.";
                    phrase[11] = "Ask again later.";
                    phrase[12] = "Better not tell you now.";
                    phrase[13] = "Cannot predict now.";
                    phrase[14] = "Concentrate and ask again.";
                    phrase[15] = "Don't count on it.";
                    phrase[16] = "My reply is no.";
                    phrase[17] = "My sources say no.";
                    phrase[18] = "Outlook not so good.";
                    phrase[19] = "Very doubtful.";
                    Random phrases = new Random();
                    int random = phrases.Next(phrase.Length);
                    Console.WriteLine(phrase[random]);
                    Console.WriteLine("Would you like to ask me another question? (Y/N):");
                    if (Console.ReadLine().ToLower() == "y" || Console.ReadLine().ToLower() == "yes")
                    {
                        Console.Clear();
                    }//end if
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        exit = true;
                    }//end else
                }//end else
            } while (!exit); //end do while
        }//end Main()
    }//end class
}//end namespace
