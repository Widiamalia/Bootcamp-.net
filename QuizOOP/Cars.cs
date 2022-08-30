using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay4OOP
{
    internal class Cars
    {
        private string noPolisi;
        private int tahun;
        private string typeCars;
        private decimal totalRevenue = 0M;

        public Cars(string noPolisi, int tahun, string typeCars)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.typeCars = typeCars;
            this.totalRevenue = totalRevenue;
        }

        public Cars(string noPolisi, int tahun)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.typeCars = typeCars;
            this.totalRevenue = totalRevenue;
        }

        public override string? ToString()
        {
            return $"No Polisi = {this.noPolisi} | Tahun = {this.tahun} | Type = {this.typeCars} " +
                $"| Total Revenue : {this.totalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string TypeCars { get => typeCars; set => typeCars = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }


    }
}
