using System;

namespace WSB_C_2020_Z1
{
    class WSB_C_2020_Z1
    {
        static void Main(string[] args)
        {
            // Zadanie 2 - kalkulator silni

            // Tablica pomocnicza przechowującą "silnie" do obliczenia
            int[] silnie = { 9, 12, 20 };

            // Pętla iterująca po tablicy silni
            for (int i = 0; i < silnie.Length; i++)
            {
                // Zmienna przechowująca wynik
                ulong wynik = 1;

                // Pętla licząca silnie
                for (int j = 1; j <= silnie[i]; j++)
                {
                    // Konwersja jawna do ulong, żeby zmienna "j" była w tym samym typie co nasz wynik
                    wynik = wynik * (ulong)j;
                }

                Console.WriteLine("Wartość " + silnie[i] + "! jest równa: " + wynik);
            }

            // Wstrzymanie okna 
            Console.WriteLine("Naciśnij enter aby wyjść");
            Console.ReadLine();
        }
    }
}
