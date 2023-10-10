using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Podaj liczbe a: ");
            double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj liczbe b: ");
            double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj liczbe c: ");
            double c = Convert.ToDouble(Console.ReadLine());
        
        double d = b*b - 4 * a * c;
        Console.WriteLine("Delta wynosi: {0}", d);
        
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
  }
}
