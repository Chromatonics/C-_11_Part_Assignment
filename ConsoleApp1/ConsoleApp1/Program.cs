
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

        Console.WriteLine("Select an Index:");
        string sSelect = Console.ReadLine();

        int index = sList.IndexOf(sSelect);
        if (index >= 0)
        {
            Console.WriteLine(String.Format("Element {0} found at index {1}", sSelect, index));
        }
        else
        {
            Console.WriteLine("Element not found in given list.");
        }
        Console.ReadLine();
    }

}
