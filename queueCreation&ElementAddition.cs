using System;
using System.Collections;
using System.Collections.Generic;

public class queueCreate
{
    public static void Main()
    {
        Queue<int> callerIds = new Queue<int>();                //Queue Creation

        callerIds.Enqueue(11);                                        //Element Addition
        callerIds.Enqueue(12);
        callerIds.Enqueue(13);
        callerIds.Enqueue(14);

        foreach(var id in callerIds)
        {
            Console.Write(id+" ");                                        //printing element of Queue
        }
        Console.WriteLine();

    }
}