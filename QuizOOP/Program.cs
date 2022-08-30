using static System.Console;
using QuizDay4OOP;

/*WriteLine("================================CARS=========================");

SUV suv1 = new SUV("D 1001 UM", 2015, 500_000, 100_000);
SUV suv2 = new SUV("D 1002 UM", 2019, 500_000, 100_000);

Taxi tax1 = new Taxi("D 88 UK", 2018, 5, 4500, 40, 10_000);
Taxi tax2 = new Taxi("D 87 UK", 2018, 10, 4500, 100, 10_000);

Angkot ang1 = new Angkot("D 55 UJ", 2016, 4500, 35);
Angkot ang2 = new Angkot("D 55 UJ", 2015, 4500, 40);


List<Cars> listCars = new List<Cars> { suv1, suv2, tax1, tax2, ang1, ang2 };
foreach (var item in listCars)
{
    WriteLine($"{item.ToString()}");
}*/

WriteLine("\n==============================Implementation Interface========================\n");

ICars cars = new CarsImpl();
var listCars = cars.GetCars();
cars.ShowList(ref listCars);

WriteLine("\n==============================Total Revenue By Type===========================\n");
var byRevenue = cars.GetTotalRevenueByType(listCars);
cars.ShowListRevenue(byRevenue);

WriteLine("\n================================Total Car By Type=============================\n");
var byType = cars.TotalCarByType(listCars);
cars.ShowListType(byType);

WriteLine("\n=================================Find Revenue Range============================\n");
var byRange = cars.FindRevenueRange(listCars,500_000,600_000);
cars.ShowList(ref byRange);
