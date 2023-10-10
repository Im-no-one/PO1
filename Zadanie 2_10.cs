using System;

class Program {
    static void Main(string[] args) {
    int powierzchnia = 100, osoby = 10;
    double gestoscZaludnienia = Convert.ToDouble(osoby)/powierzchnia; // Typem zmiennej 'osoby' jest int, przez co dzielenie jej nie zapisuje cyfr po przecinku -> Przekonwertowano w typ double przed podzieleniem liczby
    Console.WriteLine(gestoscZaludnienia);
    
        
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
  }
}
