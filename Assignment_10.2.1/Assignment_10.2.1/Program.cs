
/*
1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Write a program in C# Sharp to find the +ve numbers from a list of numbers using where conditions in LINQ Query.

+ve is shorthand for positive numbers.
what is the data type for input? array, list?
do I need to parse out the input into numbers?
how do I display the positive numbers? 
can do a foreach for every pos number or return a collection?
do the positive numbers need to be sorted?
dealing with whole numbers or decimals?

array { -1, 0, 10, 1} ----> 10, 1
list {0, .5, 1} ----> .5, 1

int[] nums {numbers to test}

(LINQ) var posNums =nums.Where(n >=0)

cw(posNums)

*/
    
float[] numbers = {-1.5f, -.5f, 0, 1f, .3f, 2.4f, 5f, -100f, -5f, 2f};
var posNums = numbers.Where(n => n >= 0);

Console.WriteLine($"""
                  For the input of {string.Join(", ", numbers)}
                  the positive numbers are {string.Join(", ", posNums)}
                  """);
                  