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
            get { return _name; } // get accesor
            set {
                if (value == "")
                {
                  _name = "Default name";
                }
                else
                {
                    _name = value;
                }
            } // set accesor
        }

        // Default Constructor 
        public Car()
        {
            _name = "Car";
            _horsepower = 5;    
            _color = "red";
        }

        public int MaxSpeed { get; set; }

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



// What is the primary purpose of using properties in C#?

// provide controlled access to class members
//properties allow you to provide controlled
//access to class members, often including
//some logic to ensure the validity of the data.


// In C#, what term is used to describe the special methods
// associated with properties that get executed when
// you set or get the value?

// accessor, accessors refer to the get and set methods within properties.


//Auto-implemented properties are best suited when: you need a simple
//way to get or set the value without any additional logic
//Auto-implemented properties are best when you need a
//simple way to get or set values without additional logic.