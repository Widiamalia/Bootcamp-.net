using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Customer : Person
    {
        private string accountNumber;

        public Customer(string firstName, string lastName, string email, DateTime birthday, string accountNumber) : base(firstName, lastName, email, birthday)
        {
            SocialNumber = new Random().Next(1000, 1100);
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthday;
            this.accountNumber = accountNumber;
        }

        public override string? ToString()
        {
            return $"{base.ToString()}; | AccountNumber : {this.accountNumber}";
        }

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }

        public override decimal TotalIncome(Dictionary<string, decimal> data)
        {
            var totalIncome = 0M;
            foreach (var item in data)
            {
                totalIncome += item.Value;
            }

            return totalIncome;

        }
    }
}
