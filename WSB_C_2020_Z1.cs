using System;

namespace WSB_C_2020_Z1
{
    class WSB_C_2020_Z1
    {
        static void Main(string[] args)
        {
            // Zadanie 2.1 - kalkulator silni - z możliwością wpisywanie silni do obliczenia

            // Prośba o liczbę
            Console.Write("Wpisz z jakiej liczby chcesz policzyć silnię (max 21!): ");

            try
            {
                // Przechwycenie ewentualnych wyjątków, by program się nie zawiesił

                // Odczyt liczby od użytkownika
                int silnia = int.Parse(Console.ReadLine());

                if (silnia >= 21)
                {
                    Console.WriteLine("Liczba z poza zakresu, niby gdzie miałbym włożyć wynik?");
                    // Wyjście z programu, bo nie da się policzyć takiej silni
                    return;
                }

                // Zmienna przechowująca wynik
                ulong wynik = 1;

                // Pętla licząca silnie
                for (int i = 1; i <= silnia; i++)
                {
                    // Konwersja jawna do ulong, żeby zmienna "j" była w tym samym typie co nasz wynik
                    wynik = wynik * (ulong)i;
                }

                Console.WriteLine("Wartość " + silnia + "! jest równa: " + wynik);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Nie poprawny format liczby, tylko liczby proszę!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak ;(");
            }

            // Wstrzymanie okna 
            Console.WriteLine("Naciśnij enter aby wyjść");
            Console.ReadLine();
        }
    }
}
