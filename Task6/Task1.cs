namespace Task6
{
    //1.	Implement a Car class which has fields to store the car's make,
    //      year, Type, Price, model, Pallet No, and color
    class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public string PalletNo { get; set; }
        public string Color { get; set; }
        //2.	Create function name DisplayInfo take two parameters	(make, year)
        virtual public void DisplayInfo(string make, int year)
        {
            Make = make;
            Year = year;
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Year: " + Year);
        }
        //3.	Create function name DisplayInfo take three parameters	(make)
        virtual public void DisplayInfo(string make)
        {
            Make = make;
            Console.WriteLine("Make: " + Make);
        }
        // 4.	This class contain function name (Display) that print statement (Welcome Car)
        virtual public void Display()
        {
            Console.WriteLine("Welcome Car");
        }
        //       create  a BMW Class  inherit from Car Class 
        //         a-  create object from  BMW then call the function DisplayInfo
        //         b-  create object from  BMW then call the function Display
    }
    class BMW : Car
    {
        override public void Display()
        {
            Console.WriteLine("Welcome BMW");
        }
        override public void DisplayInfo(string make, int year)
        {
            Year = year;
            Make = make;
            Console.WriteLine("This is a BMW and it's year is {0} and make is {1}", year, make);
        }
    }
    class Task1
    {
        public static void Task1Solution()
        {
            Car car = new();
            car.DisplayInfo("Lada", 2000);
            car.Display();
            BMW bmw = new();
            bmw.DisplayInfo("Lada", 2000);
            bmw.Display();
        }
    }
}