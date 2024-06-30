using System.Text.RegularExpressions;

namespace Task4
{
    
    class Person
    {
        public int Age;
        public string Gender;
        public string Name;
        public string Email;
        public string ID;
        public string Phone;

        public Person(int age, string gender, string name, string email, string id, string phone)
        {
            if (18 <= age && age <= 60)
                Age = age;
            else throw new ArgumentOutOfRangeException("Age must be between 18 and 60");
            if (gender == "Male" || gender == "Female")
                Gender = gender;
            else throw new ArgumentException("Gender must be either Male or Female");

            Name = name;
            var reg = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (reg.IsMatch(email))
                Email = email;
            else throw new ArgumentException("Email is not valid");
            ID = id;

            reg = new Regex(@"^(079|077|078)\d{7}$");
            if (reg.IsMatch(phone))
                Phone = phone;
            else throw new ArgumentException("Phone is not valid");
        }
        public void ShowData()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Phone: {Phone}");
        }
    }
    class Program
    {
        // Create a method that calculates the average of 10 numbers.
        static double[] Average(params double[] numbers)
        {
            return [numbers.Average(), numbers.Sum()];
        }
        static void ShowCubes(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} cubed is {1}", i, Math.Pow(i, 3));
            }
        }
        static int[] GetYears(int[] years)
        {
            var newYears = new List<int>();
            foreach (int year in years)
                if (year > 1950)
                    newYears.Add(year);
            return newYears.ToArray();
        }
        public static string ConvertYearsToDays(int years)
        {
            return $"The age in days is {years * 365}";
        }
        static void Main(string[] args)
        {
            // // Task 1
            // var x = Average(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            // Console.WriteLine("The average is {0} and the sum is {1}", x[0], x[1]);
            // // Task 2
            // Console.WriteLine("Enter the number of cubes to print: ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // ShowCubes(n);
            // // Task 3
            // Console.WriteLine("The array [1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020] becomes after filtering [{0}]",
            //  string.Join(", ", GetYears([1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020])));
            // // Task 4
            // Console.Write("Enter the amount of years to convert to days: ");
            // int years = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(ConvertYearsToDays(years));
            // Task 5
            Person p = new(19, "Male", "John", "john@gmail.com", "123456789", "0779123456");
            p.ShowData();

        }
    }


}
