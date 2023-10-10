using System;

class Program {
    static void Main(string[] args) {
        int x, y = 5;
        x = ++y *2;
        x = y++;
        x = y--;
        // x = 7, y = 6
        Console.WriteLine(++y); // x = 7, y = 7
        
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
  }
}
