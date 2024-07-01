using System.Drawing;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            BMWCar car = new(2020, 10000, "Toyota", "123456", "Red");
            car.StartEngine();
            car.StopEngine();
            Console.WriteLine(car.CarDetails());
        }
    }
    class Car(int year, string type, decimal price, string model, string palletNumber, string color)
    {
        protected int year = year;
        protected string type = type;
        protected decimal price = price;
        protected string model = model;
        protected string palletNumber = palletNumber;
        protected string color = color;
        protected bool engineStarted;

        public void StartEngine()
        {
            if (engineStarted)
            {
                Console.WriteLine("Engine already started");
                return;
            }
            engineStarted = true;
            Console.WriteLine("Engine started");
        }
        public void StopEngine()
        {
            if (!engineStarted)
            {
                Console.WriteLine("Engine already stopped");
                return;
            }
            engineStarted = false;
            Console.WriteLine("Engine stopped");
        }
        public void Move()
        {
            if (engineStarted)
            {
                Console.WriteLine("Car has moved");
                return;
            }
            Console.WriteLine("You have to start the engine first");
        }
        public string CarDetails()
        {
            return string.Format("Year: {0}, Type: {1}, Price: {2}, Model: {3}, Pallet Number: {4}, Color: {5}, Engine Started: {6}",
             year, type, price, model, palletNumber, color, engineStarted);
        }
    }
    class BMWCar : Car
    {
        public BMWCar(int year, decimal price, string model, string palletNumber, string color)
            : base(year,"BMW", price, model, palletNumber, color)
        {}
        
    }
}
