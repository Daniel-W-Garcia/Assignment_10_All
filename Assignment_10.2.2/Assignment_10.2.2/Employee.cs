namespace Assignment_10._2._2;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Salary: {Salary}\n";
        
    }
}