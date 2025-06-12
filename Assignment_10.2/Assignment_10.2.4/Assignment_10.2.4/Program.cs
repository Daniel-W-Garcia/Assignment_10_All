/*
1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.

How many numbers do I need to put into a list?
Can I use Random() to generate them?
This would be excessive to try and use a delegate here, right?
Do I need to sort the list once I have it, or return the numbers in order?
LINQ isn't stated as a param, but I will assume it's encouraged since that's the block we're in
Are we dealing with natural numbers, signed ints, or decimal numbers?

List<int> nums { 50, 60, 70, 80, 90, 100 };
new List<int> greaterThan80 = {90, 100}

List<int> numbersGreaterThan80 = nums.Where(n => n > 80).ToList

CW(string.Join(", ", numbersGreaterThan80);
*/
var random = new Random();
var numbers = new List<int>();
Console.Write("How many random numbers should we add to the list? ");
try
{
    var isValid = int.TryParse(Console.ReadLine(), out var result);
    if (isValid)
    {
        for (int i = 0; i < result; i++)
        {
            numbers.Add(random.Next(1, 501));
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and 500");
}

Console.WriteLine($"""
                  
                  The random numbers are:
                  {string.Join(", ", numbers)}
                  """);
var numbersGreaterThan80 = numbers.Where(n => n > 80).ToList();
Console.WriteLine($"""
                   
                   Of the numbers chosen by The Computer, the following are greater than 80:
                   {string.Join(", ", numbersGreaterThan80)}
                   
                   """);
