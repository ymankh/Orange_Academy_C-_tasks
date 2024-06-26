// Task 1: 1-	Create console application that read string from user and print the 
// same string
var value = Console.ReadLine();
Console.WriteLine("You write " + value);
// Task2: 2-	Define variables with kind of a.	 Double b.	String  c.	Char 
// d.	Bool e.	Int f.	Const
double dbl = 5.5;
string str = "String";
char cr = 'c';
bool isTrue = true;
int number = 20;
const double pi = 3.14;
Console.WriteLine("The value of the constant pi is " + pi);
Console.WriteLine("The value of the variable is number is " + number);
Console.WriteLine("The value of the string  str is " + str);
Console.WriteLine("The value of the character cr is " + cr);
Console.WriteLine("The value of the double dvl is " + dbl);
Console.WriteLine("The value of the boolean isTrue is " + isTrue);
// Task 3: Define array with name car that hold more than 3 kinds on cars, then print
// all the cars with the array length.
string[] cars = new string[3];
cars[0] = "Volvo";
cars[1] = "BMW";
cars[2] = "Mercedes";
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}
Console.WriteLine("The length of the array is " + cars.Length);
// Task 4:	Write a program in C that reads a first name, surname and year of birth and
// display the names and the year one after another sequentially. Go to the editor
Console.Write("Enter your first name: ");
var firstName = Console.ReadLine();
Console.Write("Enter your surname: ");
var surname = Console.ReadLine();
Console.Write("Enter your year of birth: ");
var yearOfBirth = Console.ReadLine();
Console.WriteLine(firstName + " " + surname + " was born in " + yearOfBirth);

// Task 5: Write a program in C # to store elements in an array and print it. 
var numbers = new String[5];
Console.WriteLine("•	Input 10 elements in the array ");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter element " + i + ": ");
    numbers[i] = Console.ReadLine();
}
Console.WriteLine("Elements in the array: ");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
// Task 6: Write a program in C# to find the sum of all elements of the array.
int[] intArray = { 10, 7, 32, 5, 1 };
Console.WriteLine("Sum of all elements in the array: " + intArray.Sum());
Console.ReadLine();