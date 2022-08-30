using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay4OOP
{
    internal class SUV : Cars
    {

        private decimal sewa;
        private decimal supir;

        public SUV(string noPolisi, int tahun, decimal sewa, decimal supir) : base(noPolisi, tahun)
        {
            this.TypeCars = "SUV   ";
            this.sewa = sewa;
            this.supir = supir;
            TotalRevenue = sewa + supir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Supir { get => supir; set => supir = value; }

        public override string? ToString()
        {
            return $"{base.ToString()}; | Sewa = {this.sewa.ToString("C", new CultureInfo("id-ID"))}      | Supir = {this.supir.ToString("C", new CultureInfo("id-ID"))}";
        }

        


    }
}
