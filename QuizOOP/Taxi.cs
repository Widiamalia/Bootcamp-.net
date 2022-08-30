using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay4OOP
{
    internal class Taxi : Cars
    {
        private int order;
        private int orderPerKM;
        private int totalKM;
        private decimal bonus;

        public Taxi(string noPolisi, int tahun, int order, int orderPerKM, int totalKM, decimal bonus) : base(noPolisi, tahun)
        {
            this.order = order;
            this.orderPerKM = orderPerKM;
            this.totalKM = totalKM;
            this.bonus = bonus;
            this.TypeCars = "Taxi  ";
            TotalRevenue = (order * bonus) + (orderPerKM * totalKM);
        }

        public int Order { get => order; set => order = value; }
        public int OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public int TotalKM { get => totalKM; set => totalKM = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }

        public override string? ToString()
        {
            return $"{base.ToString()}; | Order = {this.order} | Order PerKM = {this.orderPerKM} " +
                $"| Total KM = {this.totalKM} | Bonus : {this.bonus.ToString("C", new CultureInfo("id-ID"))}";


        }





    }
}
