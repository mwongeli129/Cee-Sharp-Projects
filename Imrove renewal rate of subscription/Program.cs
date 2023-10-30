using System;

class Program
{
       static void Main ()
       {
        Random random = new Random ();
        
        int daysUntilExpiration = random.Next (12);
        int discountPercentage = 0;

        if (daysUntilExpiration <=10)
        {
            Console.WriteLine ("Your subscription will expire soon.renew now!");
        }

        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine("Your subscription expires in 5 days!");
            discountPercentage = 10; 
        }
        if (daysUntilExpiration == 1)
        {
            Console.WriteLine ("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration == 0)
        {
            Console.WriteLine ("Your subscription has expired.");
        }
        if (discountPercentage > 0)
        {
            Console.WriteLine ($"Renew now and save {discountPercentage}%");
       }
}
}