using Assignment_10._2._2;

/*
1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Write a program to create a list of employees. Consider a hard coded list. Display all employees who have salary more than $5000 and age < 30.

This is not stated but impled we use LINQ for our list
I think this might be a place we can use a delegate? 
Is this a list of type Employee?
Should I make a class of Employee with properties for age and salary? 
Then hard code the employees into a list then LINQ over them?

dave, 29, $6k ---> false
mike, 30, $4k ---> false
Jeff, 31, $5k ---> true -->add to list

pub class Employee
{
    public list name {get, set}
    public int age {get, set}
    public int salary {get set}
}    

public delegate bool EmployeeScreener (Employee employee)
private List<Employee> employees
Func bool EmployeeOver30 (Employee employee)
{
    var over30 = employee.Where(age => age > 30)
    foreach employee in over30
    {
        employees.Add(employee)
    }
}
Func bool EmployeMakesMoreThan5k (Employee employee)
{
    var baller = employee.Where(salary => salary > 5000)
    foreach employee in baller
    {
        employees.Add(employee)
    }
}


*/

var employees = new List<Employee>
{
    new Employee {Name = "Dave", Age = 42, Salary = 6000},
    new Employee {Name = "Mike", Age = 30, Salary = 4000},
    new Employee {Name = "Jeff", Age = 31, Salary = 5100},
    new Employee {Name = "Sarah", Age = 25, Salary = 5500},
    new Employee {Name = "Tom", Age = 28, Salary = 7000}

};

bool Over30(Employee employee)
{
    return employee.Age > 30;
}

bool MakesMoreThan5k(Employee employee)
{
    return employee.Salary > 5000;
}

var screenedEmployees = new List<Employee>();
EmployeeScreener ageScreener = Over30;
EmployeeScreener salaryScreener = MakesMoreThan5k;

foreach (var employee in employees)
{
    screenedEmployees = employees.Where(emp => ageScreener(emp) && salaryScreener(emp)).ToList();
}

Console.WriteLine($"""
                   The employees who are older than 30 and make more than $5,000 are:
                   
                   {string.Join("", screenedEmployees)}
                   """);



public delegate bool EmployeeScreener (Employee employee);