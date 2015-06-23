using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Positive int < 100: ");
        byte n = byte.Parse(Console.ReadLine());
        double a = 1,b=1;
  
        n++;
        for (byte i = 2; i < n; i++)
        {
            a *= i;
        }
  
        n++;
        for (byte i = n; i <= 2*(n - 2); i++)
        {
            b *= i;
        }
        Console.WriteLine("The answer is: " + b/a);
    }
}
