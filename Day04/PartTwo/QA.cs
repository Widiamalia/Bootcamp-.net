using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class QA : Employee
    {
        private decimal Makan = 0M;
        private int v;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, int v) 
            : base(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.v = v;
        }

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, decimal makan) 
            : base(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.Makan = makan;
            this.Role = "QA";
            //call method TotalSalary belong Employee
            TotalSalary = TotalSalary + makan;
        }

        public decimal Makan1 { get => Makan; set => Makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()}; | Tunjangan Person = {this.Makan.ToString("C", new CultureInfo("id-ID"))} | Total salary = {TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
