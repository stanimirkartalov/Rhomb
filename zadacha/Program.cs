/*
using System;
//using Internal;

namespace Rhomb;

class Program
{
    static void Main(string[] arg)
    {

        Console.Write("Enter a value: ");
        string num = Console.ReadLine();
        int n = int.Parse(num);
        if (n % 2 == 0 & n >= 6 & n <= 80)
        {
            int midY = (n / 2) - 1;
            int midX = (n / 2) - 1;
            int i = midY + 1;
            // Console.WriteLine(n);
            int counterX = 0;
            do
            {
                int counterY = 0;

                do
                {
                    Console.Write(".");

                    counterY++;
                } while (counterY < midY);
                do
                {
                    Console.Write("/");
                    counterY++;
                } while (counterY <= midY);

                int counterS = midY + 2;
                while (counterS <= counterS + 2 & counterS < n - midY)
                {

                    Console.Write(" ");
                    counterS++;
                }
                Console.Write("\\");



                counterY = midY + 2;
                do
                {
                    Console.Write(".");
                    counterY++;

                } while (counterY <= n);

                    midY--;
                 Console.WriteLine("");
                counterX++;
            } while (counterX < midX);

        }

        else
        {
            Console.WriteLine("Invalid value!");
        }

        Console.ReadLine();
    }


}
*/
using System;
using System.Diagnostics.Metrics;

namespace Rhomb
{

    class Program
    {
        static void Main(string[] arg)
        {

            Console.Write("Enter a value: ");
            string num = Console.ReadLine();
            int n = int.Parse(num);
            if (n % 2 == 0 & n >= 6 & n <= 80)
            {
                //value is valid
                int midY = (n / 2) - 1;
                int midX = (n / 2) - 1;
                //  int i = midY + 1;
                Console.WriteLine(n);
                int counterX = 0;

                //write upper half - line by line
                do
                {
                    //write dots on left
                    int counterY = 0; //todo - rename to cursor; must add 1 on each written symbol
                    do
                    {
                        Console.Write(".");
                        counterY++;
                    } while (counterY < midY);

                    //write 1 fwd slash and increase counter
                    Console.Write("/");
                    counterY++;

                    //write as many spaces as needed in the middle
                    int counterS = midY + 2;
                    //counterS <= counterS + 2  --> always true
                    while (counterS < n - midY)
                    {
                        Console.Write(" ");
                        counterS++;
                        //add to the cursor counter 1 for each simbol
                        counterY++;
                    }

                    //write bwrd slash and increase cursor - counterY
                    Console.Write("\\");
                    counterY++;

                    //write dots on the right
                    do
                    {
                        Console.Write(".");
                        counterY++;
                    } while (counterY < n);

                    //increase space left to the middle part
                    midY--;
                    //go on next line
                    Console.WriteLine("");
                    counterX++;
                } while (counterX < midX);


                //write last line of upper half
                Console.Write("/");
                int i = 2;
                while (i < n)
                {
                    Console.Write(" ");
                    i++;
                }
                Console.Write("\\");
                Console.WriteLine("");
                counterX++; //add 1 to rows counter

                //write first line of lower half
                Console.Write("\\");
                int j = 2;
                while (j < n)
                {
                    Console.Write(" ");
                    j++;
                }
                Console.Write("/");
                Console.WriteLine("");
                counterX++; //add 1 to rows counter
                midY++;
                //write lower half
                do
                {
                    // test
                    int counterYD = 0; //todo - rename to cursor; must add 1 on each written symbol
                    do
                    {
                        Console.Write(".");
                        counterYD++;
                    } while (counterYD < midY);

                    Console.Write("\\");
                    counterYD++;

                    int counterSD = midY + 2;
                    //counterS <= counterS + 2  --> always true
                    while (counterSD < n - midY)
                    {
                        Console.Write(" ");
                        counterSD++;
                        //add to the cursor counter 1 for each simbol
                        counterYD++;
                    }

                    Console.Write("/");
                    counterYD++;

                    do
                    {
                        Console.Write(".");
                        counterYD++;
                    } while (counterYD < n);

                    midX++;
                    int counterXD = n - midX;
                    Console.WriteLine("");
                    counterXD++;
                    counterX++; // add 1 to line counter
                    midY++;
                } while (counterX <n);

            }

            else
            {
                Console.WriteLine("Invalid value!");
            }

            Console.ReadLine();
        }


    }
}