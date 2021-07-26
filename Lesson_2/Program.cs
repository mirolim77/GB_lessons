using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Temp = new string[2];
            try
            {
                Console.WriteLine("input MAX temperature: ");
                Temp[0] = Console.ReadLine();
                Console.WriteLine("input MIN temperature: ");
                Temp[1] = Console.ReadLine();
                //Temp[0] = 0;
                //Temp[1] = 1;
                int average = (Int32.Parse(Temp[0]) + Int32.Parse(Temp[1])) / 2;
                //double average = (2.0+3.0) / 2;

                if (average % 2 == 0)
                {
                     double  d_average = (double.Parse(Temp[0]) + double.Parse(Temp[1])) / 2;
                    Console.WriteLine("average temperature is: " + d_average  + " C");
                }
                else
                {
                    Console.WriteLine("average temperature isss: " + average + " C");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("input must digitel!");
                throw;
            }
            
        }
    }
}
