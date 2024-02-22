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




// Access Modifiers

/*
 * public >	    The code is accessible for all classes
 * 
 * private >	The code is only accessible within the same class
 * 
 * protected >	The code is accessible within the same class, or 
 *              in a class that is inherited from that class. 
 *           
 * internal >	The code is only accessible within its own assembly, but not from another assembly. 
 *
 */


// If you declare a field with a private access modifier, it can only be accessed within the same class:
class Car
{
    private string model = "Mustang";

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
}
// Mustang



// If you declare a field with a public access modifier, it is accessible for all classes:

class Car
{
    public string model = "Mustang";
}

class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
}




// Encapsulation
// It is used to protect sensitive data from external entities.
// To achieve this, you must: declare fields/variables as private and provide public get and set methods,
// through properties, to access and update the value of a private field

// Properties
// A property is like a combination of a variable and a method, and it has two methods: GET, SET

class Person
{
    private string name; // field

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
}

/*
The Name property is associated with the name field. 
It is a good practice to use the same name for both the property and the private field, 
but with an uppercase first letter.

The get method returns the value of the variable name.

The set method assigns a value to the name variable. 
The value keyword represents the value we assign to the property.
*/


class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}
// Liam




// Automatic Properties (Short Hand)
class Person
{
    public string Name  // property
    { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}




// Inheritance
/*
In C#, it is possible to inherit fields and methods from one class to another. 
We group the "inheritance concept" into two categories:

Derived Class (child) - the class that inherits from another class
Base Class (parent) - the class being inherited from
To inherit from a class, use the : symbol.

In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):
*/

class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

class Program
{
    static void Main(string[] args)
    {
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}





// Polymorphism and Overriding Methods
/*
Polymorphism means "many forms", and it occurs when we have many classes that are related to 
each other by inheritance.

Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. 
Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in 
different ways.

For example, think of a base class called Animal that has a method called animalSound(). 
Derived classes of Animals could be Pigs, Cats, Dogs, Birds - And they also have their own implementation 
of an animal sound (the pig oinks, and the cat meows, etc.):
*/

class Animal  // Base class (parent) 
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

// Now we can create Pig and Dog objects and call the animalSound() method on both of them:

class Animal  // Base class (parent) 
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}


// The animal makes a sound
// The animal makes a sound
// The animal makes a sound





// Abstraction
/*
Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces:

Abstract class > is a restricted class that cannot be used to create objects (to access it, it must be 
inherited from another class).

Abstract method > can only be used in an abstract class, and it does not have a body. The body is provided 
by the derived class (inherited from).

An abstract class can have both abstract and regular methods.
*/

abstract class Animal 
{
  public abstract void animalSound();
  public void sleep() 
  {
    Console.WriteLine("Zzz");
  }
}

// it is not possible to create an object of the Animal class:
Animal myObj = new Animal(); // Will generate an error 


// To access the abstract class, it must be inherited from another class. 
// Let's convert the Animal class we used in the Polymorphism chapter to an abstract class:
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.sleep();  // Call the regular method
    }
}



// Interface
// It is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):
interface Animal
{
    void animalSound(); // interface method (does not have a body)
    void run(); // interface method (does not have a body)
}


/*
To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class. 
To implement an interface, use the : symbol (just like with inheritance). The body of the interface method 
is provided by the "implement" class. Note that you do not have to use the override keyword when 
implementing an interface:
*/
// Interface
interface IAnimal
{
    void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.animalSound();
    }
}





// Enums
// An enum is a special "class" that represents a group of constants (unchangeable/read-only variables):

enum Level
{
    Low,
    Medium,
    High
}
// you can access an enum with the dot syntax:
Level myVar = Level.Medium;
Console.WriteLine(myVar);


// You can also have an enum inside a class:
class Program
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    static void Main(string[] args)
    {
        Level myVar = Level.Medium;
        Console.WriteLine(myVar);
    }
}
// Medium



// By default, the first item of an enum has the value 0. The second has the value 1, and so on.
enum Months
{
    January,    // 0
    February,   // 1
    March,      // 2
    April = 6,  // 6
    May,        // 7
    June,       // 8
    July        // 9
}

static void Main(string[] args)
{
    int myNum = (int)Months.April;
    Console.WriteLine(myNum);
}
// 3






// Files
// The File class from the System.IO namespace, allows us to work with files:

using System.IO;  // include the System.IO namespace

File.SomeFileMethod();  // use the file class with methods


/*
The File class has many useful methods for creating and getting information about files. 
For example:

AppendText()	Appends text at the end of an existing file
Copy()	        Copies a file
Create()	    Creates or overwrites a file
Delete()	    Deletes a file
Exists()	    Tests whether the file exists
ReadAllText()	Reads the contents of a file
Replace()	    Replaces the contents of a file with the contents of another file
WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.

*/



// Write To a File and Read It

using System.IO;  // include the System.IO namespace

string writeText = "Hello World!";  // Create a text string
File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
Console.WriteLine(readText);  // Output the content

// Hello World!



// Try and Catch
// The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.

try
{
    //  Block of code to try
}
catch (Exception e)
{
    //  Block of code to handle errors
}
