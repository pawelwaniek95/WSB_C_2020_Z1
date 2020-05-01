using System;
using System.Runtime.CompilerServices;

namespace WSB_C_2020_Z1
{
    class WSB_C_2020_Z1
    {

        static void Main(string[] args)
        {
            // Zadanie 5

            // Wysłanie komunikatów do użytkownika
            Console.WriteLine("### Kalkulator ###");

            // Wywołanie klasy kalkulator
            Kalkulator();

            Console.WriteLine();
            Console.WriteLine("Aby zakończyć wciśnij enter");
            Console.ReadLine();

        }

        static float Kalkulator()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int flagaBledu = 0;

            // Pobranie danych wejściowych od użytkownika i poprawienie ewentualnego błędu w przecinku, gdy użytkownik dał kropkę zamiast przecinka
            String liczbaDoParsowania = Console.ReadLine();
            liczbaDoParsowania = liczbaDoParsowania.Replace(".", ",");

            // Zmienna przechowująca pierwszą liczbę
            float liczba1 = 0;

            // Gdy wystąpi bład parsowania, flaga zostanie ustawiona
            if (!float.TryParse(liczbaDoParsowania, out liczba1))
            {
                flagaBledu = 1; Console.WriteLine("Błąd parsowania pierwszej liczby");

            }

            // Zmienna przechowująca drugą liczbę
            float liczba2 = 0;

            if (flagaBledu == 0)
            {
                Console.Write("Podaj drugą liczbę: ");

                // Ponowne wykorzystanie już utworzonej zmiennej przechowującej dane wejściowe
                liczbaDoParsowania = Console.ReadLine();
                liczbaDoParsowania = liczbaDoParsowania.Replace(".", ",");

                if (flagaBledu == 0 && !float.TryParse(liczbaDoParsowania, out liczba2))
                {
                    flagaBledu = 1;
                    Console.WriteLine("Błąd parsowania drugiej liczby");
                }
            }

            // Zmienna przechowująca decyzję użytkownika
            int decyzja = 0;

            if (flagaBledu == 0)
            {
                Console.WriteLine("Jaką operację chcesz wykonać?");
                Console.WriteLine("1 - dodawanie");
                Console.WriteLine("2 - odejmowanie");
                Console.WriteLine("3 - mnożenie");
                Console.WriteLine("4 - dzielenie");
                Console.Write("Operacja: ");

                if (!int.TryParse(Console.ReadLine(), out decyzja))
                {
                    flagaBledu = 1;
                    Console.WriteLine("Błąd parsowania działania");
                }
            }

            // Linia odstępu
            Console.WriteLine();

            float wynik = 0;

            if (flagaBledu == 0)
            {
                switch (decyzja)
                {
                    case 1: // Dodawanie
                        Console.WriteLine(liczba1 + " + " + liczba2 + " = " + dodaj(liczba1, liczba2));
                        break;

                    case 2: // Odejmowanie
                        Console.WriteLine(liczba1 + " - " + liczba2 + " = " + odejmij(liczba1, liczba2));
                        break;

                    case 3: // Mnożenie
                        Console.WriteLine(liczba1 + " * " + liczba2 + " = " + pomnoz(liczba1, liczba2));
                        break;

                    case 4: // Dzielenie
                        Console.WriteLine(liczba1 + " / " + liczba2 + " = " + podziel(liczba1, liczba2));
                        break;

                    default:
                        Console.WriteLine("Nie podano operacji, więc idę spać, Dobranoc!");
                        break;
                }
            }
            return wynik;
        }

        static float dodaj(float liczba1, float liczba2)
        {
            return liczba1 + liczba2;
        }

        static float odejmij(float liczba1, float liczba2)
        {
            return liczba1 - liczba2;
        }

        static float pomnoz(float liczba1, float liczba2)
        {
            return liczba1 * liczba2;
        }

        static float podziel(float liczba1, float liczba2)
        {
            float wynik = 0;
            try
            {
                // Jako, że zmienne typu float nie wywołują wyjątku dzielenia przez zero to musimy wymusić ręcznie ten wyjątek, by użyć obsługi wyjątków
                if (liczba2 == 0)
                {
                    throw new DivideByZeroException();
                }

                wynik = liczba1 / liczba2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Pamiętaj [...] nie dziel przez zero!");
            }
            catch (Exception e)
            {
                // Gdyby wystąpił inny wyjątek, którego nie uwzględniono
                Console.WriteLine("Coś poszło nie tak... Spróbuj jeszcze raz");
            }
            return wynik;
        }

    }
}