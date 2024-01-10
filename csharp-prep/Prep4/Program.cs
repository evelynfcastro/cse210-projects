using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number=-1;
        List<int> numbers = new List<int>();
        
         while (number!=0)
         {
            Console.Write("Enter a number:");
            number= int.Parse(Console.ReadLine());
           
           if (number !=0)
           {
            numbers.Add(number);
           }

         }
         int total= 0;
         foreach (int item in numbers)
         {
            total+=item;
         }
        Console.WriteLine($"The sum is: {total}");
        
        float avarenge= ((float)total)/numbers.Count;
        
        Console.WriteLine($"The avarenge is: {avarenge}");
        int max = numbers[0];

        foreach ( int item in numbers)
        {
            if(item>max)
            max=item;
        }
        Console.WriteLine($"The max number is: {max}");
    }

}