using System;
using System.Collections;
using System.Collections.Generic;

public class peekMethod
{
    public static void Main()
    {
        Queue<string> strQueue = new Queue<string>();

        strQueue.Enqueue("H");
        strQueue.Enqueue("e");
        strQueue.Enqueue("l");
        strQueue.Enqueue("l");
        strQueue.Enqueue("o");

        Console.WriteLine("Total elements : "+strQueue.Count);

        if(strQueue.Count > 0)
        {
            Console.WriteLine(strQueue.Peek());                 //Peek() method selecting 1st element from string
        }
        Console.WriteLine("Total elements : "+strQueue.Count);

        if(strQueue.Contains("H"))
        {
            Console.WriteLine("True");                          //Contains() method checking element present or not
        }
    }
}