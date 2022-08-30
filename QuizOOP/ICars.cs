using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay4OOP
{
    internal interface ICars
    {
        public List<Cars> GetCars();

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Cars> list);

        public void ShowListRevenue(Dictionary<string, decimal> list);

        public Dictionary<string, int> TotalCarByType(List<Cars> list);

        public List<Cars> FindRevenueRange(List<Cars> list, decimal startFrom, decimal endTo);

        public void ShowListType(Dictionary<string, int> list);

        public void ShowList<T>(ref List<T> list);

    }
}
