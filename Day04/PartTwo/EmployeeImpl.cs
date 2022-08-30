using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public Employee FindEmployeeById(List<Employee> list, int id)
        {
            Employee? emps = null;
            foreach (var item in list)
            {
                if(item.EmpId == id)
                {
                    emps = item;
                }
            }
            return emps;
        }

        public List<Employee> FindSalaryRange(List<Employee> list, decimal startfrom, decimal endTo)
        {
            var empRange = new List<Employee>();

            foreach (var item in list)
            {
                if (item.TotalSalary >= startfrom && item.TotalSalary <= endTo)
                {
                    empRange.Add(item);
                }
            }

            return empRange;
        }

        public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list)
        {
            throw new NotImplementedException();
        }

        /* public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list)
         {

         }*/

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var total = 0M;
            //OfType dgunakan jika data yan dikirimkan generic dan kita ingin akses attribute
            //dan kita ingin akses attribute sebuah class employee
            foreach (var item in list.OfType<Employee>())
            {
                total += item.TotalSalary;
            }
            return total;
        }

        public List<Employee> InitDataEmployee()
        {

            Programmer prog2 = new Programmer(1001, "Anton", "Pratama", new DateTime(2015, 03, 03), 6_000_000, "bogor", 500_000);
            Programmer prog3 = new Programmer(1002, "Budi", "Junaedi", new DateTime(2016, 08, 15), 6_000_000, "bogor", 500_000);
            Programmer prog4 = new Programmer(1003, "Charlie", "Van Dijk", new DateTime(2017, 09, 05), 6_000_000, "bogor", 500_000);
            Sales mysales1 = new Sales(1004, "Dian", "Permana", new DateTime(2017, 10, 12), 3_000_000, 500_000, 200_000);
            Sales mysales2 = new Sales(1005, "Fatur", "Rohman", new DateTime(2019, 01, 15), 3_000_000, 350_000, 250_000);
            QA myqA1 = new QA(1006, "Ellise", "Toon", new DateTime(2019, 01, 15), 4_500_000, 10_000);
            QA myqA2 = new QA(1007, "Gita", "Gutawa", new DateTime(2019, 03, 01), 4_500_000, 10_000);

            // store to list return, with variable
            /*   List<Employee> listEmps = new List<Employee> { prog1, prog2, prog3, prog4, mysales1, mysales2, myqA1, myqA2 };
               foreach (var item in listEmps);*/

            //direct return withour variable
            return new List<Employee> { prog2, prog3, prog4, mysales1, mysales2, myqA1, myqA2 };
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
              Console.WriteLine($"{item}");
            }
            // throw new NotImplementedException();
        }
    }
}
