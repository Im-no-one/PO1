using System;

class Program {
    static void Main(string[] args) {
    int x = 1, y = 3, z = 4;
    bool wynik = (x == 1 || y++ > 2 || ++z > 0);
    Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
    // wynik = True, x = 1, y = 3, z = 4 
        
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
  }
}
