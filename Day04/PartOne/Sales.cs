﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class Sales : Employee
    {
        private decimal bonus;
        private decimal commision;

        public Sales(int empId, string firstName, string lastName, DateTime joinDate,
            decimal basicSalary, string city,  decimal bonus, decimal commision) : base(empId, firstName,
                lastName, joinDate, basicSalary, city)
        {
            this.bonus = bonus;
            this.commision = commision;
            TotalSalary = basicSalary + bonus + commision;
            this.Role = "Sales";
        }

        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commision { get => commision; set => commision = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Tunjangan Sales = {this.bonus.ToString("C", new CultureInfo("id-ID"))} | " +
                $"{this.commision.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
