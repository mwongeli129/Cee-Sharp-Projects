﻿using System;

class program 
{ 
    static void Main ()
    { 
        string[] fraudulentOrderIDs = { "A123" , "B456", "C789"};

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";
        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

}
} 