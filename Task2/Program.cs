// Task 2: Write a program that inters two number and display the largest number.

Console.WriteLine("Enter two numbers.");
var numbers = new int[2];
Console.Write("First number: ");
numbers[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
numbers[1] = Convert.ToInt32(Console.ReadLine());
Array.Sort(numbers);
Console.WriteLine("The smaller number is {0}.", numbers[0]);

// Task 2: Write a C# conditional statement to find the sign
// of input  number. Display sign.

Console.WriteLine("Enter a number. : ");
var number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The Sign of the number is." + Convert.ToString(Math.Sign(number)).Replace("-1", "Negative").Replace("1", "Positive"));


// Task 3: 3.	Write a C# conditional statement to sort three
// numbers ascending. Use console to display the result.

Console.WriteLine("Enter three numbers.");
var threeNumbers = new int[3];

Console.Write("Number {0}: ", 0 + 1);
threeNumbers[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Number {0}: ", 1 + 1);
threeNumbers[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Number {0}: ", 2 + 1);
threeNumbers[2] = Convert.ToInt32(Console.ReadLine());

Array.Sort(threeNumbers);

Console.WriteLine("The sorted numbers are {0}, {1} and {2}.", threeNumbers[0], threeNumbers[1], threeNumbers[2]);
// Task 4: Write a C# conditional statement to find the max of five numbers. Use console to display the result

Console.WriteLine("Enter five numbers.");
var fiveNumbers = new int[5];

Console.Write("Number {0}: ", 0 + 1);
fiveNumbers[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Number {0}: ", 1 + 1);
fiveNumbers[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Number {0}: ", 2 + 1);
fiveNumbers[2] = Convert.ToInt32(Console.ReadLine());

Console.Write("Number {0}: ", 3 + 1);
fiveNumbers[3] = Convert.ToInt32(Console.ReadLine());

Console.Write("Number {0}: ", 4 + 1);
fiveNumbers[4] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The max number is {0}.", fiveNumbers[4]);

// Task 5: Write a C# program that converts kilometers per hour to miles per hour.  
// Expected Output:
Console.Write("Enter the speed in kilometers per hour: ");
var speed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The speed in miles per hour is {0}.", speed * 0.621371);

// Task 6: Write a C# program that takes hours and minutes as input and calculates
// the total number of minutes.

Console.Write("Enter hours: ");
var hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minutes: ");
var minutes = Convert.ToInt32(Console.ReadLine());
var totalMinutes = hours * 60 + minutes;
Console.WriteLine("The total number of minutes is {0}.", totalMinutes);

// Task 7: Write a program in C# that takes minutes as input and display the total
// number of hours and minutes.
Console.Write("Enter minutes: ");
var minutesInput = Convert.ToInt32(Console.ReadLine());
hours = minutesInput / 60;
minutes = minutesInput % 60;
Console.WriteLine("The total number of hours is {0}.", hours);
Console.WriteLine("The total number of minutes is {0}.", minutes);

// Task 8: Create string of array that contains 5 element of different sentence with
// different length . Print all elements with fixed length for each sentence.

var sentences = new string[] {"Don't let the trees make not to see the forest.",
"The five boxing wizards jump quickly.",
"Pack my box with five dozen liquor jugs.", "I hate the taste of the rain in summer.", "We accept the love that we think we deserve."};

Console.WriteLine("The sentence: {0}, has the length: {1}", sentences[0], sentences[0].Length);
Console.WriteLine("The sentence: {0}, has the length: {1}", sentences[1], sentences[1].Length);
Console.WriteLine("The sentence: {0}, has the length: {1}", sentences[2], sentences[2].Length);
Console.WriteLine("The sentence: {0}, has the length: {1}", sentences[3], sentences[3].Length);
Console.WriteLine("The sentence: {0}, has the length: {1}", sentences[4], sentences[4].Length);
