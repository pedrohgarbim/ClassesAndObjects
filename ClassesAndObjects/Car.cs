using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// clas is a blueprint for creating objects

//A Class itself can be seen as Type and each time a new Object of that Class is created,
//a new "Instance" of that Class is created.

// methods (functions) that an object of that class will have
namespace ClassesAndObjects
{
    internal class Car
    {
        // private Member variable/fields
        // access modifier private
        private string _name; // private field for storing data
        private int _horsepower; 
        private string _color;

        // the public property
        public string Name { 
            get { return _name; } 
            set { _name = value; }
        }

        // Default Constructor 
        public Car()
        {
            _name = "Car";
            _horsepower = 5;    
            _color = "red";
        }

        // Partial Specification Constructor
        public Car(string name, int horsepower = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _horsepower = horsepower;
            _color = "red";
        }

        // Full Specification Constructor
        public Car(string name, int horsepower, string color = "black")
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _horsepower = horsepower;
            _color = color;
        }

        // Member Method
        public void Drive()
        {
            Console.WriteLine(_name+ " is driving");
        }

        // Member Method
        public void Stop()
        {
            Console.WriteLine(_name + "Car stopped!");
        }

        // Member Method
        public void Details()
        {
            Console.WriteLine("The car " + _name + " has " + _horsepower + " HorsePower and have " +
                " the color " + _color);
        }

    }
}

// to know about getters and setters

//public int GetHorsePower()
//{
//    return _horsepower*_horsepower;
//}
//public void SetName(string name)
//{
//    if(name == "")
//    {
//        _name = "DefaultName";
//    }
//    else
//    {
//        _name = name;

//    }
//} 

//public string GetName()
//{
//    return _name + " suffix";
//}

