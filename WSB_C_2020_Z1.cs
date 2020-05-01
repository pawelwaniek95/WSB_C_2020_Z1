using System;

namespace WSB_C_2020_Z1
{
    class WSB_C_2020_Z1
    {
        static void Main(string[] args)
        {
            // Zadanie 3 podzadanie 2

            // Flaga pokazująca, czy liczby są poprawnie pobrane
            int badFLag = 0;

            // Pobranie parametrów od użytkownika
            Console.WriteLine("### Kalkulator ###");
            Console.Write("Podaj pierwszą liczbę: ");
            int liczba1 = 0;

            // Gdy wystąpi bład parsowania, flaga zostanie ustawiona
            if (!int.TryParse(Console.ReadLine(), out liczba1))
            {
                badFLag = 1; Console.WriteLine("Błąd parsowania pierwszej liczby");
            }

            Console.Write("Podaj drugą liczbę: ");
            int liczba2 = 0;
            if (!int.TryParse(Console.ReadLine(), out liczba2)) { badFLag = 1; Console.WriteLine("Błąd parsowania drugiej liczby"); }

            Console.WriteLine("Jaką operację chcesz wykonać?");
            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            Console.WriteLine("3 - mnożenie");
            Console.Write("Operacja: ");

            int decyzja = 0;
            if (!int.TryParse(Console.ReadLine(), out decyzja)) { badFLag = 1; Console.WriteLine("Błąd parsowania działania"); }

            int wynik = 0;

            if (badFLag == 0)
            {
                switch (decyzja)
                {
                    case 1: // Dodawanie
                        wynik = liczba1 + liczba2;
                        Console.WriteLine(liczba1 + " + " + liczba2 + " = " + wynik);
                        break;

                    case 2: // Odejmowanie
                        wynik = liczba1 - liczba2;
                        Console.WriteLine(liczba1 + " - " + liczba2 + " = " + wynik);
                        break;

                    case 3: // Mnożenie
                        wynik = liczba1 * liczba2;
                        Console.WriteLine(liczba1 + " * " + liczba2 + " = " + wynik);
                        break;

                    default:
                        Console.WriteLine("Nie podano operacji, więc idę spać, Dobranoc!");
                        break;
                }

            }
        }
    }
}