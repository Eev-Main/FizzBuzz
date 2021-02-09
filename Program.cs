using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] arrayNum = new int[100];
            for (int i = 0; i < arrayNum.Length; i++)
            {
             arrayNum[i] = i + 1; 
            }
            for (int i = 0; i < arrayNum.Length; i++)
            {
                 if (arrayNum[i]%100 == 0)
                 {
                    Console.WriteLine("FizzBuzz");
                 }
                 else if (arrayNum[i]%3 == 0 && arrayNum[i]%5 == 0)
                 {
                    Console.WriteLine("FizzBuzz");
                 }
                 else if (arrayNum[i]%3 == 0)
                 {
                     Console.WriteLine("Fizz");
                 }
                 else if (arrayNum[i]%5 == 0 )
                 {
                     Console.WriteLine("Buzz");
                 }
                 else
                    Console.WriteLine(arrayNum[i]);
        }
    }
}
