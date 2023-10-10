using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Podaj temperature (w stopniach Celsjusza:)");
        double C = Convert.ToDouble(Console.ReadLine());
        double F = 32d + 9d / 5d * C;
        Console.WriteLine("{0} stopni Celsjusza to {1} stopni Fahrenheita", C, F);
        
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
  }
}
