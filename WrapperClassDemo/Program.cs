
// Amir Moeini Rad
// September 2025

// Help from ChatGPT

// Main Concept: Wrapper Class
// A wrapper class is a class that "wraps" or encapsulates another class or data type to provide additional functionality,
// modify behavior, or simplify usage.
// Wrapper classes are often used to add features such as logging, validation, or resource management without altering the original class.
// In real projects, wrappers are widely used in logging, database access, API calls, and unit testing.


namespace WrapperClassDemo
{
    // ------------- //
    // WRAPPED CLASS //
    // ------------- //


    // A sample class to be wrapped by the wrapper class.
    // The original class
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
    }


    // ------------- //
    // WRAPPER CLASS //
    // ------------- //


    // Wrapper class for the 'Calculator' class
    // The wrapper class adds logging functionality to the 'Add' method of the 'Calculator' or wrapped class.
    // The wrapped class is used internally by the wrapper class.
    public class CalculatorWrapper
    {
        private readonly Calculator _calculator;

        public CalculatorWrapper()
        {
            _calculator = new Calculator();
        }

        // Wrapper method
        public int AddNumbers(int x, int y)
        {
            // Adding logging functionality to the original Add() method.
            Console.WriteLine($"Adding {x} and {y}...");
            return _calculator.Add(x, y);
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
            

            CalculatorWrapper calc = new CalculatorWrapper();
            int result = calc.AddNumbers(5, 7);

            Console.WriteLine($"Result: {result}");

            
            Console.WriteLine("\nDone.");
        }
    }
}
