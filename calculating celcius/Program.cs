using System;

    class Program
    {
        static void Main () 
        {
        int fahreinheit = 94;
        //To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).

            decimal celsius = (fahreinheit - 32m) * (5m/9m);

        Console.WriteLine ("The temperature is " + celsius + " Celsius.");
        
    }
}




