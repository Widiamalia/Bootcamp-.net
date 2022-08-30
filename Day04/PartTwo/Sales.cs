using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Sales : Employee
    {
        private decimal Bonus;
        private decimal Commision;
        private int v1;
        private int v2;

        public Sales(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, int v1, int v2) : base(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Sales(int empId, string firstName, string lastName, DateTime joinDate,
            decimal basicSalary, string city, string role, decimal bonus, decimal commision) : base(empId, firstName,
                lastName, joinDate, basicSalary, city, role)
        {
            this.Bonus = bonus;
            this.Commision = commision;
            TotalSalary = basicSalary + bonus + commision;
            this.Role = "Sales";
        }

        public decimal Bonus1 { get => Bonus; set => Bonus = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Tunjangan Sales = {this.Bonus.ToString("C", new CultureInfo("id-ID"))} | " +
                $"{this.Commision.ToString("C", new CultureInfo("id-ID"))} | Total salary = {TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
