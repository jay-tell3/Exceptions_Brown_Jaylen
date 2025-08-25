using System;

namespace Exceptions_Brown_Jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result= 0f;
            
            Random random = new Random();
            int myInt = random.Next(2,30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("please put in a diffent number from zero");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                try
                {
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            finally 
            {
            Console.WriteLine("Calculations completed with the result of "+result);
            }

            try
            {
                CheckAge(myInt);
            }
            catch
            {
            Console.WriteLine($"you are {myInt} witch is not old eough!");
            }
        }
        static float Divide(float x, float y) 
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else 
            {
            return x/ y;
            }
        }

        static void CheckAge(int age)
        {
            if (age >= 17) 
            { 
                Console.WriteLine($"You are {age} you can play"); 
            } 
            else
            { 
                throw new ArgumentException(); 
            }
        }

    }
}