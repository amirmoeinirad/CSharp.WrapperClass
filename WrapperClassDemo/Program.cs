
// Amir Moeini Rad
// September 2025

// Help from ChatGPT

// Main Concept: Wrapper Class

// A wrapper class is a class that "wraps" or encapsulates another class or data type to provide additional functionality,
// modify behavior, or simplify usage.
// Wrapper classes are often used to add features such as logging, validation, or resource management
// without altering the original class.
// In real projects, wrappers are widely used for logging, database access, API calls, and unit testing.


namespace WrapperClassDemo
{
    // ------------- //
    // WRAPPED CLASS //
    // ------------- //


    // A sample class to be wrapped by a wrapper class.
    // The original class
    // This calculator class just adds two numbers.
    public class OldCalculator
    {
        // Original method
        public int Add(int a, int b) => a + b;
    }


    // ------------- //
    // WRAPPER CLASS //
    // ------------- //


    // The Wrapper class for the 'Calculator' class
    // The wrapper class adds logging functionality to the 'Add' method of the 'Calculator' or wrapped class.
    // The wrapped class is used internally by the wrapper class.
    public class NewCalculator
    {
        private readonly OldCalculator _oldCalculator;

        public NewCalculator()
        {
            _oldCalculator = new OldCalculator();
        }

        // Wrapper method
        public int AddNumbers(int x, int y)
        {
            // Adding logging functionality to the original Add() method.
            Console.WriteLine($"Adding {x} and {y}...");
            return _oldCalculator.Add(x, y);
        }
    }


    // -------------//
    // MAIN PROGRAM //
    // ------------ //


    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Wrapper Classes in C#.NET...");
            Console.WriteLine("----------------------------\n");


            // The wrapper class just adds logging functionality to the original class.
            // The actual addition is still performed by the original wrapped class.
            NewCalculator calc = new NewCalculator();
            int result = calc.AddNumbers(5, 7);

            Console.WriteLine($"Result: {result}");

            
            Console.WriteLine("\nDone.");
        }
    }
}
