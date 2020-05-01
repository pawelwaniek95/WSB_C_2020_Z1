using System;

namespace WSB_C_2020_Z1
{
    class WSB_C_2020_Z1
    {
        static void Main(string[] args)
        {
            // Zadanie 3

            // Pobranie parametrów od użytkownika
            Console.WriteLine("### Mnożenie dwóch liczb ###");
            Console.WriteLine("Podaj pierwszą liczbę");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int liczba2 = int.Parse(Console.ReadLine());

            int wynik = liczba1 * liczba2;
            Console.WriteLine(liczba1 + " * " + liczba2 + " = " + wynik);

        }
    }
}
