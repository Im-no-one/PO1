using System;

class Program {
    static void Main(string[] args) {
        bool x;
        int y = 1, z = 1;
        x = (y == 1 && z++ == 1);
        // a) x = true, y = 1, z = 2
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
  }
}
