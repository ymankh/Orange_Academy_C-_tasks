namespace Task6
{
    //     1.Define an Interface
    // 	    Create an interface named ISound that includes a method void MakeSound();.
    interface ISound
    {
        void MakeSound();
    }
    //     2.	Define an Abstract Class
    // o	Create an abstract class named Animal that includes:
    // 	A property string Name { get; set; }.
    // 	A constructor that takes a string name parameter and sets the Name property.
    // 	An abstract method void Eat();.
    // 	A concrete method void Sleep() that prints out the animal's 

    abstract class Animal
    {
        protected string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat();
        public void Sleep()
        {
            Console.WriteLine("{0} is sleeping", Name);
        }

    }
    // 3.	Implement Concrete Classes
    //  o	Create two classes, Dog and Cat, that:
    //  	Inherit from Animal.
    //  	Implement the ISound interface.
    //  	Provide specific implementations for the Eat method that print out the animal's name followed by what it is eating.
    //  	Provide specific implementations for the MakeSound method that print out the animal's name followed by the sound it makes (e.g., "Woof!" for dogs and "Meow!" for cats).

    class Dog : Animal, ISound
    {
        public Dog(string name) : base(name) { }
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public override void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating");
        }
    }
    class Cat : Animal, ISound
    {
        public Cat(string name) : base(name) { }
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        public override void Eat()
        {
            Console.WriteLine($"The cat {Name} is eating");
        }
    }
    class Task2
    {
        // 4.	Create a Program to Test Your Classes
        //  o	In the Main method, create instances of Dog and Cat.
        //  o	Call the Eat, Sleep, and MakeSound methods on each instance.
        public static void Task2Solution()
        {
            Dog dog = new Dog("Dog");
            Cat cat = new Cat("Cat");
            dog.Eat();
            cat.Eat();
            dog.Sleep();
            cat.Sleep();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}