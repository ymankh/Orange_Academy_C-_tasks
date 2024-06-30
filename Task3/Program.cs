// Correct the syntax of the following code:

//	string [ ] ARR= [ 1,7  9  45, ] -> 
int[] ARR = { 1, 7, 9, 45 };

//	int arr2=["Str" "alex","moh" -> 
string[] arr2 = ["Str", "alex", "moh"];
//	string arr3= 'the','fox' 'over' lazy, 'dog',  ] -> 
string[] arr3 = ["the", "fox", "over", "lazy", "dog"];

// Task 2: What the index of "Banana","Tomato"?
string[] fruits = ["Tomato", "Banana", "Watermelon"];

Console.WriteLine("The index of Banana is :" + Array.IndexOf(fruits, "Banana"));
Console.WriteLine("The index of Tomato is :" + Array.IndexOf(fruits, "Tomato"));

// Task 3: Create an multiple arrays that represents your:
// Favorite Food(5 item)
string[] favoriteFood = ["Pizza", "Pasta", "Sushi", "Burger", "Tacos"];
// Favorite Sport(3 item)
string[] favoriteSport = ["Football", "Basketball", "Tennis"];
// Favorite Movie(4 item)
string[] favoriteMovie = ["The Shawshank Redemption", "The Godfather", "The Dark Knight", "Pulp Fiction"];
// Then, print each array using foreach, and Loop Through an Array
foreach (var item in favoriteFood)
{
    Console.Write("{0} ", item);
}
Console.WriteLine();

foreach (var item in favoriteSport)
{
    Console.Write("{0} ", item);
}
Console.WriteLine();

foreach (var item in favoriteMovie)
{
    Console.Write(" {0}", item);
}
Console.WriteLine();

// Task4: Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
Console.Write("Input three numbers separated by comma: ");
string input = Console.ReadLine();
string[] numbers = input.Replace(" ", "").Split(',');

double sum = 0;
foreach (var item in numbers)
{
    sum += Convert.ToDouble(item);
}
Console.WriteLine("The sum of three numbers: " + sum);
//	Expected Output:
//	Input three numbers separated by comma: 5,10,15
//	The sum of three numbers: 30.

// Task5: Write a program in C# to display the n terms of odd number and their sum from [1- 100 ].
Console.Write("Input the number of terms that you want to display: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum2 = 0;
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
    if (i % 2 == 1)
        sum2 += i;
}

Console.WriteLine("The sum of odd number: " + sum2);
// Task 6:	Write a program in C# to display the pattern like right angle triangle using an asterisk. Go to the editor

Console.WriteLine("Enter the number of rows of the triangle: ");
int rows = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= rows; i += 1)
{
    for (int j = 1; j <= (rows - i); j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

var counter = 0;
for (int i = 1; i <= rows; i += 2)
{

    for (int j = 1; j <= (rows - i) / 2; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
    {
        counter++;
        Console.Write("{0} ", counter);
        
    }
    Console.WriteLine();
}






