using System.Linq;

Console.WriteLine("This is a test");


//  VARIABLES  //

// Integers 

int myAge; // occupies four bytes of memory
myAge = 17;

byte myByte = 150; // whole number that goes from 0 to 255. Occupies one byte of memory
sbyte mySByte; // from -128 to 127

short myShort = 25_000; // from -32,768 to 32,767 (2 bytes)
ushort myUShort; // 0 to 65,535

long myLong; // in the billions and over (8 bytes)


// Floats

float myFloat = 3.14f; //must specify f to indicate that the literal is a float

double myDouble = 12.01; // d is not necessary

decimal myDecimal = 0.001m;


// Booleans
bool myBoolean = true;
var myBool = !myBoolean;


// Strings

char myChar = 'A'; // stores one letter only

string myString = "Then he said: \"This is an escape sequence\"";


// DateTime
DateTime dateTime = DateTime.Now;


// var requires to be initialized in the same line
var myVariable = 120;



//converting values
var newFloat = (float)myAge;


Console.WriteLine($"This is my age {myAge}");



// Constants cannot be changed
const int myConstant = 1;



/*************************************************************************/


// if statement

if (myAge >= 18 || myAge == 1000) {
    Console.WriteLine("You may pass.");
} 
else if (myAge == 1001)
{
    Console.WriteLine("I'll make an exception...");
}
else
{
    Console.WriteLine("Nope, too young!");
}



// Ternary conditional operator     CONDITION ? VALUE IF TRUE : VALUE IF FALSE

var loggedIn = false;

string welcomeBackMessage = loggedIn ? "Welcome back" : "Log in to start";




// switch statement 

var place = 2;

switch (place)
{
    case 1: // same as if (place == 1)
        Console.WriteLine("You are in position one.");
        break;

    case 2:
        Console.WriteLine("You are in position two.");
        break;

    case 3:
        Console.WriteLine("You are in position three.");
        break;

    default:
        Console.WriteLine("Better keep going.");
        break;
}


// switch expressions

var message = place switch
{
    1 => "You are in position one.", // the value of the message is going to be the string itself
    2 => "You are in position two.",
    3 or 4 => "You reached the end!",
    > 5 => "Go back before it's too late.",
    _ => "Better keep going" // if none of the above
};

Console.Write(message);




/*************************************************************************/



// ARRAYS
// Arrays, unlike dictionaries or lists, must contain elements of the same type.

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

int[] myNumArray = { 10, 20, 30, 40 };

// Create an array of four elements, and add values later
string[] someCars = new string[4];

// Create an array of four elements and add values right away 
string[] evenMoreCars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };



// Loop through an array

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

// foreach
/*
  Used exclusively to loop through elements in an array:


 foreach (type variableName in arrayName) 
{
  // code block to be executed
}


 The foreach method is easier to write, it does not require a counter (using the Length property), 
 and it is more readable.
*/

foreach (string i in cars)
{
    Console.WriteLine(i);
}



// Sort()
// Sorts an array alphabetically or in an ascending order.
Array.Sort(myNumArray);


// Min, Max, Sum
// using System.Linq;

Console.WriteLine(myNumArray.Max());  
Console.WriteLine(myNumArray.Min());  
Console.WriteLine(myNumArray.Sum());



// Multidimensional Arrays
// If you want to store data as a tabular form, like a table with rows and columns, you need multidimensional arrays.

//2D
int[,] twoDArray = { { 1, 4, 2 }, { 3, 6, 8 } };
Console.WriteLine(twoDArray[0, 2]);  // Outputs 2

// Looping through the 2D array
for (int i = 0; i < twoDArray.GetLength(0); i++)
{
    for (int j = 0; j < twoDArray.GetLength(1); j++)
    {
        Console.WriteLine(twoDArray[i, j]);
    }
}

