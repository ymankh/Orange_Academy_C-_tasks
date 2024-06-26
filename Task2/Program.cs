// Task 2: Write a program that inters two number and display the largest number.

Console.WriteLine("Enter two numbers.");
var numbers = new int[2];
Console.Write("First number: ");
numbers[0] = int.Parse(Console.ReadLine());
Console.Write("Second number: ");
numbers[1] = int.Parse(Console.ReadLine());
Array.Sort(numbers);
Console.WriteLine("The smaller number is {0}.", numbers[0]);

// Task 2: Write a C# conditional statement to find the sign
// of input  number. Display sign.
Console.WriteLine("Enter a number. : ");
var number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("The Sign of the number is Positive.");
}
else if (number < 0)
{
    Console.WriteLine("The Sign of the number is Negative.");
}

// Task 3: 3.	Write a C# conditional statement to sort three
// numbers ascending. Use console to display the result.

Console.WriteLine("Enter three numbers.");
var threeNumbers = new int[3];
for (var i = 0; i < threeNumbers.Length; i++)
{
    Console.Write("Number {0}: ", i + 1);
    threeNumbers[i] = int.Parse(Console.ReadLine());
}
if (threeNumbers[0] > threeNumbers[1])
{
    var temp = threeNumbers[0];
    threeNumbers[0] = threeNumbers[1];
    threeNumbers[1] = temp;
}
if (threeNumbers[1] > threeNumbers[2])
{
    var temp = threeNumbers[1];
    threeNumbers[1] = threeNumbers[2];
    threeNumbers[2] = temp;
}
if (threeNumbers[0] > threeNumbers[1])
{
    var temp = threeNumbers[0];
    threeNumbers[0] = threeNumbers[1];
    threeNumbers[1] = temp;
}
Console.WriteLine("The sorted numbers are {0}, {1} and {2}.", threeNumbers[0], threeNumbers[1], threeNumbers[2]);
// Task 4: Write a C# conditional statement to find the max of five numbers. Use console to display the result

Console.WriteLine("Enter five numbers.");
var fiveNumbers = new int[5];
for (var i = 0; i < fiveNumbers.Length; i++)
{
    Console.Write("Number {0}: ", i + 1);
    fiveNumbers[i] = int.Parse(Console.ReadLine());
}
if (fiveNumbers[0] > fiveNumbers[1] && fiveNumbers[0] >= fiveNumbers[2] && fiveNumbers[0] >= fiveNumbers[3] && fiveNumbers[0] >= fiveNumbers[4])
{
    Console.WriteLine("The max number is {0}.", fiveNumbers[0]);
}
else if (fiveNumbers[1] >= fiveNumbers[2] && fiveNumbers[1] >= fiveNumbers[3] && fiveNumbers[1] >= fiveNumbers[4])
{
    Console.WriteLine("The max number is {0}.", fiveNumbers[1]);
}
else if (fiveNumbers[2] >= fiveNumbers[3] && fiveNumbers[2] >= fiveNumbers[4])
{
    Console.WriteLine("The max number is {0}.", fiveNumbers[2]);
}
else if (fiveNumbers[3] >= fiveNumbers[4])
{
    Console.WriteLine("The max number is {0}.", fiveNumbers[3]);
}
else
{
    Console.WriteLine("The max number is {0}.", fiveNumbers[4]);
}
// Task 5: Write a C# program that converts kilometers per hour to miles per hour.  
// Expected Output:
Console.Write("Enter the speed in kilometers per hour: ");
var speed = double.Parse(Console.ReadLine());
Console.WriteLine("The speed in miles per hour is {0}.", speed * 0.621371);

// Task 6: Write a C# program that takes hours and minutes as input and calculates
// the total number of minutes.

Console.Write("Enter hours: ");
var hours = int.Parse(Console.ReadLine());
Console.Write("Enter minutes: ");
var minutes = int.Parse(Console.ReadLine());
var totalMinutes = hours * 60 + minutes;
Console.WriteLine("The total number of minutes is {0}.", totalMinutes);

// Task 7: Write a program in C# that takes minutes as input and display the total
// number of hours and minutes.
Console.Write("Enter minutes: ");
var minutesInput = int.Parse(Console.ReadLine());
hours = minutesInput / 60;
minutes = minutesInput % 60;
Console.WriteLine("The total number of hours is {0}.", hours);
Console.WriteLine("The total number of minutes is {0}.", minutes);

// Task 8: Create string of array that contains 5 element of different sentence with
// different length . Print all elements with fixed length for each sentence.

var sentences = new string[] {"Don't let the trees make not to see the forest.",
"The five boxing wizards jump quickly.",
"Pack my box with five dozen liquor jugs.", "I hate the taste of the rain in summer.", "We accept the love that we think we deserve."};
for (var i = 0; i < sentences.Length; i++)
{
    Console.WriteLine("The sentence: {0}, has the length: {1}", sentences[i], sentences[i].Length);
}