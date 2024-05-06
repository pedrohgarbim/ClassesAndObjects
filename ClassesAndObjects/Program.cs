namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.Name);
            myCar.MaxSpeed = 230;
           Console.WriteLine(myCar.Name +" Has the max speed "+myCar.MaxSpeed);
        }
    }
}
