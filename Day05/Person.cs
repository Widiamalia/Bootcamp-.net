using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal abstract class Person
    {
        private int socialNumber;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthday;
        private decimal totalRevenue;


        protected Person(string firstName, string lastName, string email, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthday = birthday;

        }

        public int SocialNumber { get => socialNumber; set => socialNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }


        public override string? ToString()
        {
            return $"SocialNumber : {this.socialNumber} | FullName : {this.firstName} {this.lastName} | Email : {this.email} | Birthday : {this.birthday} | Revenue : {this.totalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }

        public abstract decimal TotalIncome(Dictionary<string, decimal> data);

    }
}
