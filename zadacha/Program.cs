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
                
                Console.WriteLine(n);
                int counterX = 0;


                //write upper half - line by line
                do
                {
                    //write dots on left
                    int counterY = 0;
                    while (counterY < midY)
                    {
                        Console.Write(".");
                        counterY++;
                    } 
                        
                         
                    int limit = n - counterY*2;
                    double m = limit/ 2;
                    for ( int k=0; k < limit; k++)
                        {
                        
                            if (k < m)
                            {

                               
                                if (k % 2 != 0)
                                {
                                    Console.Write(" ");
                                }
                                else
                                {
                                    Console.Write("/");
                                }
                            }
                            else
                            {
                                if (k % 2 != 0)
                                {
                                    Console.Write("\\");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }

                    counterY = counterY + limit;


                    //write dots on the right
                    while (counterY < n)
                    {
                        Console.Write(".");
                        counterY++;
                    }

                    //increase space left to the middle part
                    midY--;
                    //go on next line
                    Console.WriteLine("");
                    counterX++;
                } while (counterX <= midX);


                midY++;
               
       
                do
                {
                    int counterYD = 0;
                    while (counterYD < midY)
                    {
                        Console.Write(".");
                        counterYD++;
                    } 
                    

                        int limit = n - counterYD * 2;
                    double m = limit / 2;
                    for (int k = 0; k < limit; k++)
                    {

                        if (k < m)
                        {

                            
                            if (k % 2 == 0)
                            {
                                Console.Write("\\");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("/");
                            }
                        }
                    }

                    counterYD = counterYD + limit;



                   
                    while (counterYD < n) 
                    {
                        Console.Write(".");
                        counterYD++;
                    } 
                    
                    midX++;
                    int counterXD = n - midX ;
                    Console.WriteLine("");
                    counterXD++;
                    counterX++; // add 1 to line counter
                    midY++;
                    
                } while (counterX < n);
                
            }

            else
            {
                Console.WriteLine("Invalid value!");
            }

            Console.ReadLine();
        }


    }
}