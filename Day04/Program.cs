using static System.Console;
// call class employee
using Day04.PartOne;


// Setiap create object instance, gunakan opeator new
Employee emp1 = new Employee();
emp1.EmpId = 1000;
emp1.FirstName = "Widi";
emp1.LastName = "Amalia";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 5_000_000;
emp1.City = "Bogor";
emp1.Role = "Programmer";



//create object Employee with parameter constructor
Employee emp2 = new Employee(1001, "Code", "Academy",
                    new DateTime(), 5_000_000, "Sentul", "Programmer");
Employee emp3 = new Employee(1002, "Asep", "Dayat",
                    new DateTime(2022, 8, 29), 5_000_000, "Bandung", "QA");
Employee emp4 = new Employee(1003, "Budi", "F",
                    new DateTime(2022, 8, 12), 6_000_000, "Jakarta", "Programmer");



WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
WriteLine($"Total Employee : {Employee.totalEmployee}");
WriteLine($"Total Employee Basic Salary : {Employee.totalbasicSalary}");
WriteLine();

WriteLine("=======================================LIST EMPLOYEE====================================");

//create object programmer
Programmer prog1 = new Programmer(1004, "Badu", "Duba", new DateTime(2021, 7, 12), 5_500_000,
                                 "Bogor", 500_000);


//create object programmer
Programmer prog2 = new Programmer(120, "Anton", "Pratama", new DateTime(2015, 03, 03), 6_000_000, "Bogor", 500_000);
Programmer prog3 = new Programmer(121, "Budi", "Junaedi", new DateTime(2016, 08, 15), 6_000_000, "Bandung", 500_000);
Programmer prog4 = new Programmer(122, "Charlie", "Van Dijk", new DateTime(2017, 09, 05), 6_000_000, "Depok", 500_000);

//create object sales
Sales mysales1 = new Sales(123, "Dian", "Permana", new DateTime(2017, 10, 12), 3_000_000, "Sentul", 500_000, 200_000);
Sales mysales2 = new Sales(125, "Fatur", "Rohman", new DateTime(2019, 01, 15), 3_000_000, "Jakart", 350_000, 250_000);

//create object QA
QA myqA1 = new QA(124, "Ellse", "Toon", new DateTime(2019, 01, 15), 4_500_000, "Sukabumi", 10_000);
QA myqA2 = new QA(124, "Ellse", "Toon", new DateTime(2019, 03, 01), 4_500_000, "Solo", 10_000);


// store to list
List<Employee> listEmps = new List<Employee> { prog1, prog2, prog3, prog4, mysales1, mysales2, myqA1, myqA2 };
foreach (var item in listEmps)
{
    WriteLine(item.ToString());
}


/*WriteLine("======================================Implementation Interface===================================");
//call interface & implementation

IEmployee empInf = new EmployeeImpl();

var listOfEmps = empInf.InitDataEmployee();
empInf.ShowList(ref listOfEmps);

var emp = empInf.FindEmployeeById(listOfEmps,1002);
WriteLine($"Found : {emp}");

var total = empInf.GetTotalSalary(ref listOfEmps);
WriteLine($"Total Salary : {total}");

WriteLine("--------------Salary Range-------------");
var empsSalaryRange = empInf.FindSalaryRange(listOfEmps, 2_000_000, 4_500_000);
empInf.ShowList(ref empsSalaryRange);
*/

ReadLine();

