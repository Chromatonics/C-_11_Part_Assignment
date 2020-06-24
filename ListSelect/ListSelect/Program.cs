
using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<string> sList = new List<string>();
        sList.Add("Hello");
        sList.Add("Hello");
        sList.Add("World");
        sList.Add("It's");
        sList.Add("me!");

        int muple = 1;
        int duple = 0;
        foreach (string str in sList)
        {
            if (str == "Hello")
                duple++;
            if (str == "Hello")
                Console.WriteLine(str + " appears " + duple + " times");
            else if (str != "Hello")
                Console.WriteLine(str + " appears " + muple + " time");
        }
        Console.ReadLine();
    }
}

