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
            catch (System.FormatException exception)
            {
                
                Console.WriteLine("input must be digitel!");
                 // throw;
            }



            
            string []month_array= {"jenuary","fevral","mart","april","may","june","july","avgust",
                "september","octamber","november","december" };
             Console.WriteLine("input month  number: ");
            int m_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input month number: " + month_array[m_number-1]);


            Console.WriteLine("check number of even");
            int number_entered= Convert.ToInt32(Console.ReadLine()); bool number= true;
            if (number_entered % 2!=0)
            {
                number = false;
            }
            Console.WriteLine("input number is even? : " + number.ToString());











        }
    }
}
