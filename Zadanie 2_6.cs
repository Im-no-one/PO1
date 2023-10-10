using System;

class Program {
    static void Main(string[] args) {
        int x, y = 4;
        x = (y -=2);
        x = y++;
        x = y--;
        // x = 3, y = 2
        Console.WriteLine(x);
        Console.WriteLine(y);
        
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
  }
}
