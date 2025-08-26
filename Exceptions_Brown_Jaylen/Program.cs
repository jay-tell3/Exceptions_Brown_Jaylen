using System;

namespace Exceptions_Brown_Jaylen
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize three float variable
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            // Create a Random age number
            Random random = new Random();
            // Generate a random number between 2 and 29
            int myInt = random.Next(2, 30); 

            try
            {
                // divides the numbers
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                // Handles division by zero
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero:");

                // Gets a new value from user input
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    // Try division again with the new number
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    // If it fails again it will display a error
                    Console.WriteLine(e2.Message);
                }
            }
            finally
            {
                // This block always runs, regardless of whether an exception occurred
                Console.WriteLine("Calculations completed with the result of " + result);
            }

            try
            {
                // Checks if age is high eough 
                CheckAge(myInt);
            }
            catch
            {
                // if the age is to low
                Console.WriteLine($"You are {myInt}, which is not old enough!");
            }
        }

        // Method to divide two float numbers
        static float Divide(float x, float y)
        {
            if (y == 0)
            {
                // Throw an exception if dividing by zero
                throw new DivideByZeroException("Attempted to divide by zero.");
            }
            else
            {
                return x / y;
            }
        }

        // checks if the age is 17 or older
        static void CheckAge(int age)
        {
            if (age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play.");
            }
            else
            {
                // Throw an exception if age is below 17
                throw new ArgumentException("Age is too low.");
            }
        }
    }

}