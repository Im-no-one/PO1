using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Podaj wage (w kg): ");
            double a = Convert.ToDouble(Console.ReadLine());
            a *=  10000;
        Console.WriteLine("Podaj wzrost: ");
            double b = Convert.ToDouble(Console.ReadLine());
        
        double r = a / (b * b);
        Console.WriteLine("Twoje BMI wynosi: {0}", r);
        
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
  }
}
