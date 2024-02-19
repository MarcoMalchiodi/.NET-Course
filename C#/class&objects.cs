// OOP

// A class is a template for objects, and an object is an instance of a class.
// When the individual objects are created, they inherit all the variables and methods from the class.



// Class 

using System.Security.Claims;

class Macchina
{
    string colore = "red";
}

// To create an object of Car, specify the class name, followed by the object name, and use the keyword new:

class Car
{
    string color = "red";

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
    }
}


// Multiple objects

class Car
{
    string color = "red";
    static void Main(string[] args)
    {
        Car myObj1 = new Car();
        Car myObj2 = new Car();
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj2.color);
    }
}


/*
You can also create an object of a class and access it in another class. 
This is often used for better organization of classes (one class has all the fields and methods, 
while the other class holds the Main() method (code to be executed)).

prog2.cs:

class Car 
{
  public string color = "red";
}


prog.cs:

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}

*/




// Class Members
// Fields and methods inside classes are often referred to as "Class Members":

// The class
class MyClass
{
    // Class members
    string color = "red";        // field
    int maxSpeed = 200;          // field
    public void fullThrottle()   // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }
}



// Object Methods
// Methods normally belong to a class, and they define how an object of a class behaves.
// Just like with fields, you can access methods with the dot syntax. However, note that the method must be public.

class Car
{
    string color;                 // field
    int maxSpeed;                 // field
    public void fullThrottle()    // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.fullThrottle();  // Call the method
    }
}




// Multiple Classes
/*
 
prog2.cs:

class Car 
{
  public string model;
  public string color;
  public int year;
  public void fullThrottle()
  {
    Console.WriteLine("The car is going as fast as it can!"); 
  }
}



prog.cs:

class Program
{
  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}

*/




// Constructors
// A constructor is a special method that is used to initialize objects. The advantage of a constructor,
// is that it is called when an object of a class is created.It can be used to set initial values for fields:

class Car
{
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
        model = "Mustang"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
        Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
        Console.WriteLine(Ford.model);  // Print the value of model
    }
}

// Outputs "Mustang"




// Constructor Parameters
/*
Constructors can also take parameters, which is used to initialize fields.

The following example adds a string modelName parameter to the constructor. 
Inside the constructor we set model to modelName (model=modelName). When we call the constructor, 
we pass a parameter to the constructor ("Mustang"), which will set the value of model to "Mustang":            */


class Car
{
    public string model;

    // Create a class constructor with a parameter
    public Car(string modelName)
    {
        model = modelName;
    }

    static void Main(string[] args)
    {
        Car Ford = new Car("Mustang");
        Console.WriteLine(Ford.model);
    }
}

// Outputs "Mustang"



// You can have as many parameters as you want:

class Car
{
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }

    static void Main(string[] args)
    {
        Car Ford = new Car("Mustang", "Red", 1969);
        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
}


// Outputs Red 1969 Mustang