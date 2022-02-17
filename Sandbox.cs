using System;
using System.Collections.Generic;
namespace TestProject1
{
    internal class Sandbox

    {

        public static void Main(string[] args)
        {
            Stack<int> result = null;
            Console.WriteLine("Hello world");
            Console.WriteLine("Here you can write console prints to test your implementation outside the testing environment");

            

            result.Push(5);
            result.Push(6);
            result.Push(3);
            result.Push(26);
            TestMethods.GetNextGreaterValue(result);
        }  
    }
}
