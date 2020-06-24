using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Input Text:");
        string sArray1 = Console.ReadLine();

        string[] strArray = new string[] { "Hi", "there", "this", "that" };
            foreach (string str in strArray)
            {
                Console.WriteLine(str + sArray1);
            }
        Console.ReadLine();
  
    }
}
