using System;

class MainClass {
  public static void Main (string[] args) {
     int celsius, faren;
            Console.WriteLine("Enter the Temperature in Celsius ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is " + faren);
            Console.ReadLine();
             
    if ((faren >=0) && (faren <=32))
    {
      Console.WriteLine("This temperature is below freezing temperature of 32 degrees farenheit");
    }
    else if ((faren >=33)&&(faren <= 212))
    {
      Console.WriteLine("This temperature is above boiling temperature of 212 degrees farenheit");
    }
    else
    {
       Console.WriteLine("nothing lol");
    }
    Console.ReadLine();
 

  }
}