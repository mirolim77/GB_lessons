using System;

namespace Lesson_5
{
    class EmployeesArrray
    {
        Employees[] employees_;


        public EmployeesArrray()
        {
            this.employees_ = new Employees[1];
        }



        public void SortEmployersByAgeToConsole(Employees[] _personals, int _age)
        {

            Console.WriteLine("Start sortable method by age over: " + _age);
            foreach (var item in _personals)
            {
                if (item.GetEmploerAge() > 40)
                {

                    item.GetEmployersToConsole();
                }
            }

        }


    }
}
