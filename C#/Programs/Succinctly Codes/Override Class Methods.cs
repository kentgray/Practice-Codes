using System;


namespace ConsoleApplication1
{
    class Animal
    {
        public double height { get; set; } 
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        publiAnimal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
        }

        publicAnimal(double height, double weight, string name, string soun d)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }

        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine("{0} says {1}", spot name, spot sound);

            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());

            Console.WriteLine(spot.toString());

            Console.WriteLine(spot.getSum(num2: 1.4, 2.7));

            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Grrr"
            };

            Dog spike = new Dog();

            Console.WriteLine(spike.toString());

            spike = new Dog(20, 15, "Spike", "Grr", "Chicken");

            Console.WriteLine(spike.toString());   
        }

    }
    
    class Dog : Animal
    {
        public string favFood { get; set;  }

        public Dog() : base()
        {
            this.favFood = "No Favorite Food";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }

        new public string toString()
        {
            return String.Format("{0} is {1} inches ")
        }
    }
}
