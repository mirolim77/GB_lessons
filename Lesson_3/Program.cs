using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[,] arrayy = new int[2, 4];


            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arrayy[i, j] = rd.Next(10, 55);
                }
             }

            for (int i = 0; i < arrayy.GetLength(0); i++)
            {
                for (int j = 0; j <arrayy.GetLength(1); j++)
                {
                    Console.Write( "array[" + i +"]["+j+"]= "+ arrayy[i, j] +";  ");
                }
            }

            //end Lesson 3. task1


            //start Lesson 3. task 2

            string[,] phonebook = new string[5,2];











        }
    }
}
