using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q2MathTutorApplicationSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            Random NumberRandom1 = new Random();
            Random NumberRandom2 = new Random();
            int RandomNum1 = NumberRandom1.Next(5, 26);
            int intRandomOperation = NumberRandom2.Next(1, 5);
            int intNumber1;
            int intNumber2;
            string strOperation;
            int intAnswer = 1;
            string strUserAnswer = " ";
            int intUserAnswer = 0;

            //Input
          

            //Process
            if (intRandomOperation == 1)
            {
                strOperation = ("+");
            }
            else if (intRandomOperation == 2)
            {
                strOperation = (" * ");
            }
            else if (intRandomOperation == 3)
            {
                strOperation = ("-");
            }
            else
            {
                strOperation = ("/");
            }

            intNumber1 = NumberRandom1.Next(5, 26);
            intNumber2 = NumberRandom1.Next(5, 26);
            Console.WriteLine(intNumber1 + strOperation + intNumber2);
            Console.WriteLine("What is the answer? ");
            Console.Write("The Answer is: ");
            strUserAnswer = Console.ReadLine();
            intUserAnswer = Int32.Parse(strUserAnswer);




            if (strOperation == "+")
            {
                intAnswer = intNumber1 + intNumber2;
            }
            else if (strOperation == "-")
            {
                intAnswer = intNumber1 - intNumber2;
            }
            else if (strOperation == "/")
            {
                intAnswer = intNumber1 / intNumber2;
            }
            else
            {
                intAnswer = intNumber1 * intNumber2;
            }



            //Output


            if (intAnswer == intUserAnswer)
            {
                Console.WriteLine("WOW, your answer is correct");
            }
            else if (intAnswer != intUserAnswer)
            {
                Console.WriteLine("Are You Retarded?, The Right Answer is:" + intAnswer);
            }

            Console.ReadKey();
        }
    }
}
