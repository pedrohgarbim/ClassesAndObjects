namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            //myCar.setName("myFirstCar");
            //Console.WriteLine("my car name is " + myCar.getName());
            // first we set, then we get
            myCar.Details();

            Car ram = new Car("RAM 01", 250, "blue");
            ram.Drive();
            ram.Details();

            Car maserati = new Car("MASERATI 01", 345, "white");
            maserati.Drive();
            maserati.Details();

            Console.WriteLine("Press 1 to stop the car");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                ram.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinetely");
            }
        }
    }
}
