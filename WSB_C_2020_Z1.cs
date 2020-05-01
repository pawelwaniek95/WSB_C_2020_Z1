using System;

namespace WSB_C_2020_Z1
{
    class WSB_C_2020_Z1
    {
        static void Main(string[] args)
        {
            // Zadanie 4

            // Utworzenie zmiennych potrzebych do działania programu
            bool flagaKonca = false;
            bool flagaPoprawnosci = true;
            float wynik = 0;
            float liczba = 0;
            string dzialanie = "";
            string liczbaDoParsowania = "";

            do
            {
                // Wyczyszczenie konsoli
                Console.Clear();
                // Wypisanie komunikatów na konsolę
                Console.WriteLine("### Kalkulator ###");
                Console.WriteLine("Aktualny wynik: " + wynik);
                Console.WriteLine();

                // Sprawdzanie, czy użytkownik wpisał poprawny argument
                do
                {
                    Console.WriteLine();
                    Console.Write("Jaką operację chcesz wykonać? (obsługiwane: dodawanie(+), odejmowanie(-), mnożenie(*), dzielenie(/), wyjście(n) ): ");
                    dzialanie = Console.ReadLine();
                    dzialanie = dzialanie.ToLower().Trim();

                    // Sprawdzenie, czu znaki są poprawne
                } while (!(dzialanie.Equals("+") || dzialanie.Equals("-") || dzialanie.Equals("*") || dzialanie.Equals("/") || dzialanie.Equals("n")));

                // Jeżeli użytkownik chce wyjść, to nie ma sensu pobierać już liczby
                if (!dzialanie.Equals("n"))
                {
                    do
                    {
                        Console.Write("Podaj liczbę: ");
                        // Pobranie danych wejściowych od użytkownika i poprawienie ewentualnego błędu w przecinku, gdy użytkownik dał kropkę zamiast przecinka
                        liczbaDoParsowania = Console.ReadLine();
                        liczbaDoParsowania = liczbaDoParsowania.Replace(".", ",").Trim();

                        // Dopóki użytkownik nie poda prawidłowej liczby lub "n" dopóty nie przejdzie dalej
                        if (!liczbaDoParsowania.Equals("n") && !float.TryParse(liczbaDoParsowania, out liczba))
                        {
                            Console.Write("Oczekuję liczby lub znaku \"n\"!. Spróbuj jeszcze raz: ");
                            flagaPoprawnosci = false;
                        }
                        else
                        {
                            flagaPoprawnosci = true;
                        }

                    } while (!flagaPoprawnosci);
                }

                try
                {
                    switch (dzialanie)
                    {
                        case "+": // Dodawanie
                            wynik += liczba;
                            break;

                        case "-": // Odejmowanie
                            wynik -= liczba;
                            break;

                        case "*": // Mnożenie
                            wynik *= liczba;
                            break;

                        case "/": // Dzielenie
                                  // Jako, że zmienne typu float nie wywołują wyjątku dzielenia przez zero to musimy wymusić ręcznie ten wyjątek, by użyć obsługi wyjątków
                            if (liczba == 0)
                            {
                                throw new DivideByZeroException();
                            }

                            wynik /= liczba;
                            break;

                        case "n":
                            flagaKonca = true;
                            Console.WriteLine();
                            Console.WriteLine("Wynik to: " + wynik);
                            break;

                        default:
                            Console.WriteLine("Nie podano prawidłowje, obsługiwanej operacji, więc \"n\" - aby wyjść lub spróbuj jeszcze raz ");
                            break;

                    }
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Pamiętaj [...] nie dziel przez zero!");
                    Console.WriteLine();
                    Console.WriteLine("Aby kontynuować wciśnij enter");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    // Gdyby wystąpił inny wyjątek, którego nie uwzględniono
                    Console.WriteLine("Coś poszło nie tak... Spróbuj jeszcze raz");
                    Console.WriteLine();
                    Console.WriteLine("Aby kontynuować wciśnij enter");
                    Console.ReadLine();
                }
            } while (!flagaKonca);

            Console.WriteLine();
            Console.WriteLine("Aby zakończyć wciśnij enter");
            Console.ReadLine();
        }
    }
}