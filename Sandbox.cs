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

            Stack<int> numbers = new Stack<int>();
            numbers.Push(13);
            numbers.Push(18);
            numbers.Push(6);
            numbers.Push(17);
            numbers.Push(15);


            Stack<int>resulta = TestMethods.GetNextGreaterValue(numbers);

            int[] lita =resulta.ToArray();

            for (int i = 0; i < resulta.Count; i++) 
            {
                Console.WriteLine(lita[i]);
            }
               

        }  
    }
}
