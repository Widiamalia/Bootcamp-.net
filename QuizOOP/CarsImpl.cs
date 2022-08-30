using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay4OOP
{
    internal class CarsImpl : ICars
    {
        public List<Cars> FindRevenueRange(List<Cars> list, decimal startFrom, decimal endTo)
        {
            var revRange = new List<Cars>();

            foreach (var item in list)
            {
                if (item.TotalRevenue > startFrom && item.TotalRevenue <= endTo)
                {
                    revRange.Add(item);
                }
            }
            return revRange;
        }

        public List<Cars> GetCars()
        {
            SUV suv1 = new SUV("D 1001 UM", 2015, 500_000, 100_000);
            SUV suv2 = new SUV("D 1002 UM", 2019, 500_000, 100_000);

            Taxi tax1 = new Taxi("D 88 UK  ", 2018, 5, 4500, 40, 10_000);
            Taxi tax2 = new Taxi("D 87 UK  ", 2018, 10, 4500, 100, 10_000);

            Angkot ang1 = new Angkot("D 55 UJ  ", 2016, 4500, 35);
            Angkot ang2 = new Angkot("D 55 UJ  ", 2015, 4500, 40);

            return new List<Cars> { suv1, suv2, tax1, tax2, ang1, ang2 };
        }

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Cars> list)
        {
            var totalRev = new Dictionary<string, decimal>();
            decimal revSUV = 0;
            decimal revTaxi = 0;
            decimal revAngkot = 0;
            foreach (var item in list)
            {
                if (item.TypeCars == "SUV")
                {
                    revSUV += item.TotalRevenue;
                }
                else if (item.TypeCars == "Taxi")
                {
                    revTaxi += item.TotalRevenue;
                }
                else if (item.TypeCars == "Angkot")
                {
                    revAngkot += item.TotalRevenue;
                }
            }
            totalRev.Add("SUV", revSUV);
            totalRev.Add("Taxi", revTaxi);
            totalRev.Add("Angkot", revAngkot);

            return totalRev;
        }


        public void ShowListRevenue(Dictionary<string, decimal> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public Dictionary<string, int> TotalCarByType(List<Cars> list)
        {
            var totalTypeCars = new Dictionary<string, int>();
            int totalSUV = 0;
            int totalTaxi = 0;
            int totalAngkot = 0;
            foreach (var item in list)
            {
                if (item.TypeCars == "SUV")
                {
                    totalSUV++;
                }
                else if (item.TypeCars == "Taxi")
                {
                    totalTaxi++;
                }
                else if (item.TypeCars == "Angkot")
                {
                    totalAngkot++;
                }
            }
            totalTypeCars.Add("SUV", totalSUV);
            totalTypeCars.Add("Taxi", totalTaxi);
            totalTypeCars.Add("Angkot", totalAngkot);

            return totalTypeCars;
        }

        public void ShowListType(Dictionary<string, int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
