using System;

class Program{
    static void Main(string[] args){
        // pobieranie imienia
        Console.Write("Podaj swoje imię: ");
        string imie = Console.ReadLine();

        Console.Write("Podaj swoję nazwisko: ");
        string nazwisko = Console.ReadLine();

        Console.Write("Podaj ile masz lat");
        string wiek = Console.ReadLine();

        Console.WriteLine($"{imie} {nazwisko} ma {wiek} lat");

        
    }
}
