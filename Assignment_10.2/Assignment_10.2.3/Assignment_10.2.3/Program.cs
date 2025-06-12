/*

1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Find a city that starts and ends with a specific character.
Test Data :
The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
Input starting character for the string : A
Input ending character for the string : M
Expected Output : AMSTERDAM

1. 

LINQ is not stated but I'll assume it's recommended due to our course instruction
Do I need to make a db of cities and query the db? 
Can I just hard code some cities and run logic on my list?
list is letters only? Punctuation, numbers. a sentence input I need to parse the city from? - that last part might be difficult

start char 'a' end char 'r'

Ann Arbor ---> true
Anchorage ---> false
Andover ---> true

List cityNames = new List {all the names}
var matchingCity = cityNames.Where(city[0] == start char && city.GetLenght -1 == lastChar).ToList

CW(string.Join(", ", matchingCity)

*/

List<string> cities =
[
    "ROME", "LONDON", "NAIROBI", "COMPTON", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI",
    "PARIS", "TOKYO", "DURANGO", "LITTLE ROCK", "ATHENS", "SANTA FE", "SEATTLE", "SAN FRANCISCO"
];

GetLetter getFirstLetter = input => input.Length > 0 ? input[0] : throw new ArgumentException("Cannot get first letter from null or empty string");

GetLetter getLastLetter = input => input.Length > 0 ? input[input.Length - 1] : throw new ArgumentException("Cannot get last letter from null or empty string");


Console.Write("""
              
              Hello! There is a database of cities. Try to guess a starting letter and an ending letter.
              Please enter a letter you think a city in the database starts with:
              """);
char startChar = char.ToUpper(Console.ReadLine()?[0] ?? 'A');

Console.WriteLine();
Console.Write("Now enter a ltter you think a city in the database ends with: ");
char endChar = char.ToUpper(Console.ReadLine()?[0] ?? 'M');


var matchingCities = cities.Where(city => getFirstLetter(city) == startChar && getLastLetter(city) == endChar).ToList();

if (matchingCities.Any())
{
    Console.WriteLine($"Cities that start with '{startChar}' and end with '{endChar}':");
    Console.WriteLine(string.Join(", ", matchingCities));
}
else
{
    Console.WriteLine($"No cities found that start with '{startChar}' and end with '{endChar}'");
}
Console.WriteLine();
Console.WriteLine("Thank you for playing!");

public delegate char GetLetter(string city);