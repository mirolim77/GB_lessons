using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Employees[] e = new Employees[_personals.Length];
            Console.WriteLine("Start sortable method by age:");
            foreach (var item in _personals)
            {
                if (item.GetEmploerAge() > 40)
                {
                    //e.Append(item);
                    item.GetEmployersToConsole();
                }
            }
           
        }


    }
}
