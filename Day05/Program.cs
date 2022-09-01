using static System.Console;
using Day05;

/*Person yuli = new Customer("Yuli","Ayu    ","yuli@gmail.com", new DateTime (1998,4,24), "131-001");
Customer widi = new Customer("Widi", "Amalia ", "widi@gmail.com", new DateTime(1999, 9, 30), "131-003");
Customer rini = new Customer("Rini", "Marlina", "rini@gmail.com", new DateTime(1999, 8, 4), "131-002");

var listOfCustomer = new List<Person>{ yuli, widi, rini };

var incomeYuli = new Dictionary<string, decimal>{
    {"Kontrakan",10_000_000},
    {"Toko",100_000_000}

};

yuli.TotalRevenue  = yuli.TotalIncome(incomeYuli);


var incomeWidi = new Dictionary<string, decimal>{
    {"Kosan",20_000_000},
    {"Jual Online",6_000_000}

};

widi.TotalRevenue = widi.TotalIncome(incomeWidi);

var incomeRini = new Dictionary<string, decimal>{
    {"Supermarket",50_000_000},
    {"Rental Mobil",40_000_000}

};

rini.TotalRevenue = rini.TotalIncome(incomeRini);


foreach (var item in listOfCustomer)
{
    WriteLine(item.ToString());
}

WriteLine("====================================REVENUE HIGHEST====================================");
var listRange = listOfCustomer.Where(C => C.TotalRevenue >= 50_000_000);

foreach (var item in listRange)
{
    WriteLine(item.ToString());
}

WriteLine("====================================REVENUE MINIMAL====================================");

var listMin = listOfCustomer.Min(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMin}");

WriteLine("====================================REVENUE MAXIMAL====================================");

var listMax = listOfCustomer.Max(x => x.TotalRevenue);
WriteLine($"Cust Max Revenue : {listMax}");


WriteLine("================================REVENUE LOWER THAN MAX=================================");
var listlessThanMax = listOfCustomer.Where(x => x.TotalRevenue < listMax);
foreach (var item in listlessThanMax)
{
    WriteLine(item.ToString());
}

WriteLine("========================================SELECT=========================================");

var query = listOfCustomer.Select(cust =>
    new
    {
        FullName = cust.FirstName + " " + cust.LastName,
        Email = cust.Email,
        TotalRevenue = cust.TotalRevenue
    }
        
);

foreach (var item in query)
{
    WriteLine(item);
}*/


WriteLine("======================================OWNER========================================");

Person fauzan = new Owner("Fauzan", "Lazwar", "ekos@gmail.com", new DateTime(1998, 4, 24), 50);
Owner widi = new Owner("Widi", "Amalia ", "widi@gmail.com", new DateTime(1999, 9, 30), 60);
Owner jilan  = new Owner("Jilan", "Agni  ", "agni@gmail.com", new DateTime(2007, 9, 27), 70);

var listOfOwner = new List<Person> { fauzan, widi, jilan };

var incomeFauzan = new Dictionary<string, decimal>{
    {"Galery",80_000_000},
    {"Department Store",900_000_000}

};

fauzan.TotalRevenue = fauzan.TotalIncome(incomeFauzan);


var incomeWidi = new Dictionary<string, decimal>{
    {"Apartment",700_000_000},
    {"Online Shop",88_000_000}

};

widi.TotalRevenue = widi.TotalIncome(incomeWidi);

var incomeJilan = new Dictionary<string, decimal>{
    {"Supermarket",200_000_000},
    {"Wibu Shop",40_000_000}

};

jilan.TotalRevenue = jilan.TotalIncome(incomeJilan);

foreach (var item in listOfOwner)
{
    WriteLine(item.ToString());
}

/*WriteLine("=======================================LinQ====================================");
LinQ.IntroLinq();*/
