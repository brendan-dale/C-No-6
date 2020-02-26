using System;

class Program {
  public static void Main () {
  
    Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

    Console.WriteLine ("Please enter the package weight: ");
    decimal weight = Convert.ToDecimal(Console.ReadLine());
    
    if (weight > 50) 
     {
       Console.WriteLine ("Package too heavy to be shipped via Package Express. Have a good day.");
     }
    
     
    Console.WriteLine ("Please enter the package width: ");
       decimal width = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine ("Please enter the package height: ");
       decimal height = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine ("Please enter the package length: ");
       decimal length = Convert.ToDecimal(Console.ReadLine());
     
    decimal dimensions = weight + width + height + length / 100;
    
    if (dimensions > 50)
      {
        Console.WriteLine ("Package is too big to be shipped via Package Express.");
      }

    decimal result = weight * width * height * length / 100;


    Console.WriteLine ("Your estimated total for shipping this package is: $" + result);
      
  }
}

