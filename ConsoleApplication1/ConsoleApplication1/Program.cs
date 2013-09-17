using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
             //Today we are making a fibonacchi sequence (next term = add the previous two terms, start
            // with 1 and 2. Then we will take the sum of the even terms that go up to the max.
            //God knows why.

            int firstTerm = 1;
            int secondTerm = 2;
            int thirdTerm = 0;

            int sum = 2; //I feel like this is cheating however I know the 2 is even
            //and should be added to the sum so instead of making the loop wonkey
            //I chose to do this.

            Console.WriteLine("Hi enter a max number for ProjEuler02 (hint: 4mil)");
            int max = int.Parse(Console.ReadLine()); //no sanity check

            for(int ii = 0; ii < max; ii++)
            {  
                thirdTerm = firstTerm + secondTerm;

                if (thirdTerm > max)
                {
                    break;
                }             

                if (thirdTerm % 2 == 0)
                {
                    sum = sum + thirdTerm;
                }


                firstTerm = secondTerm;
                secondTerm = thirdTerm;
            }

            Console.WriteLine("the sum of the even terms in this fibonacchi sequence is : " + sum);
            Console.ReadLine();


        } 
    }
}
