// METHODS


// template

class Program
{
    static void MyMethod()
    {
        // code to be executed
    }
}



// example

class Example
{
    public static void aMethod()
    {
        Console.WriteLine("I just got executed!");
    }

    
    static void Main(string[] args)
    {
        aMethod();
    }
    
}

/*
 * In C#, methods can be called within the class where they are defined (i.e., within the same class),
 * as well as from outside the class if they are declared with appropriate access modifiers like public, 
 * protected, or internal.
 */



// Parameters and Arguments

class Params
{
    static void ThisMethod(string fname)        
    {
        Console.WriteLine(fname + " Refsnes");
    }

    
    static void Main(string[] args)
    {
        ThisMethod("Liam");
        ThisMethod("Jenny");
    }
    
}



// Return values

class Math
{
    static int MathMethod(int x)
    {
        return 5 + x;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MathMethod(3));
    }
}

