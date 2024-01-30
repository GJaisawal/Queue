using System;
using System.Collections;
using System.Collections.Generic;

public class retrieveElement
{
    public static void Main()
    {
        Queue<string> strQ = new Queue<string>();

        strQ.Enqueue("H");
        strQ.Enqueue("e");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("o");

        Console.WriteLine("Toatal element : {0}", strQ.Count);

        while(strQ.Count > 0)
        {
            Console.Write(strQ.Dequeue());                 //Dequeue removing all element of String
        }
        Console.WriteLine();
        Console.WriteLine("Total elements: {0}", strQ.Count);
    }
    
}