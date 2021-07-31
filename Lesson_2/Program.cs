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
                    Console.WriteLine("average temperature isss: " + average + " C" + '\n');
                    
                }
                else
                {
                    double d_average = (double.Parse(Temp[0]) + double.Parse(Temp[1])) / 2;
                    Console.WriteLine("average temperature is: " + d_average + " C" + '\n');
                }

            }
            catch (System.FormatException)
            {

                Console.WriteLine("input must be digitel!");
                // throw;
            }




            string[] month_array = {"jenuary","fevral","mart","april","may","june","july","avgust",
                "september","octamber","november","december" };
            Console.WriteLine("input month  number: ");
            var m_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input AVG wather temperature: ");
            int temperature = Convert.ToInt32(Console.ReadLine());
            if (temperature > 0 && m_number >= 9)
            {
                Console.WriteLine("input month number: " + month_array[m_number - 1] + ": Rainy winter!" + '\n');
            }
            else
            {
                Console.WriteLine("input month number: " + month_array[m_number - 1]  + ": Another season!" + '\n');
            }


            Console.WriteLine("check number of even");
            int number_entered = Convert.ToInt32(Console.ReadLine()); bool number = true;
            if (number_entered % 2 != 0)
            {
                number = false;
            }
            Console.WriteLine("input number is even? : " + number.ToString() + '\n');


            int[] products_p = { 11, 55, 66, 99, 77, 99, 997 };
            string[] product_names = { "apple", "milk", "meat", "apelsin", "suger", "bread", "martini" };
            Console.WriteLine("Welcome to Supermarket ;)" + '\n'+ "---------------------------------------------------------------") ;
            Console.WriteLine("Date: " + DateTime.Now);
            int p = 0; int s = 0;
            foreach (var item in product_names)
            {
                Console.WriteLine("Product name: " + item + " --Coast: " + Convert.ToString(products_p[p]));
                s = products_p[p];
                p++;
            }
            Console.WriteLine("Total: " + s + '\n'+ "---------------------------------------------------------------"+'\n');


            //mask
            int work_days = 0b011111;

            int Monday = 0b010001;
            int Tuesday = 0b010100;
            int Wednesday = 0b010000;
            int Thursday = 0b010111;
            int Friday = 0b010111;
            int Saturday = 0b010111;
            int Sunday = 0b010111;

            int office_1 = work_days & Tuesday & Wednesday & Thursday & Friday;
            int office_2 = work_days & Monday & Tuesday & Wednesday & Thursday & Friday & Saturday & Sunday;










        }

        public enum week_days {
            Monday = 0b010001,
            Tuesday = 0b010100,
            Wednesday = 0b010000,
            Thursday = 0b010111,
            Friday = 0b010111,
            Saturday = 0b010111,
            Sunday = 0b010111,
        }



    }
}
