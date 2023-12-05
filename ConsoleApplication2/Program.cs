//Listy

using System;
using System.Collections.Generic; //Gowienko do list

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // List<int> ints = new List<int>();
            // ints.Add(1);
            // ints.Add(2);
            // ints.Add(3);
            // ints.Remove(2); //USUWA 2 A NIE LICZBE POD INDEXEM 2
            //
            // //Wyswietlanie dlugosci listy
            // Console.WriteLine("Długość listy : " + ints.Count);
            //
            // //Wyswietlenie elementow listy
            // foreach (int element in ints)
            // {
            //     Console.WriteLine(element);
            // }


            /*
             * •	Utwórz listę 10 liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
               •	Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
               •	Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.


             */
            //     List<int> lista = new List<int>();
            //     Random r = new Random();
            //     Console.WriteLine("Lista Losowych liczb");
            //     for (int i = 0; i < 10; i++)
            //     {
            //         lista.Add(r.Next(1,101));
            //     }
            //
            //     foreach (var element in lista)
            //     {
            //         Console.Write(element + " ");
            //     }
            //
            //     List<int> ListaPodzielnych3lub5 = PodzielnePrzez3Lub5(lista);
            //     Console.WriteLine("\nLista z elementami podzielnymi przez 3 lub 5");
            //     foreach (int element in ListaPodzielnych3lub5)
            //     {
            //         Console.Write(element + " ");
            //     }
            // }
            // public static List<int> PodzielnePrzez3Lub5(List<int> lista)
            // {
            //     List<int> koniec = new List<int>();
            //     foreach (int element in lista)
            //     {
            //         if (element % 3 == 0 || element % 5 == 0)
            //         {
            //             koniec.Add(element);
            //         }
            //     }
            //
            //     foreach (var element in koniec)
            //     {
            //         Console.Write(element + " ");
            //     }
            //
            //     return koniec;
            // }
            
            
            
            
               //Napisz program, który tworzy listę liczb całkowitych i wypełnia ją losowymi wartościami z zakresu od 1 do 100.
               List<int> lista = new List<int>();
               Random r = new Random();
               for (int i = 0; i < 10; i++)
               {
                   lista.Add(r.Next(1,101));
               }

               Console.WriteLine();
               Console.WriteLine("Wygenerowana Lista Liczb");
               Console.WriteLine();
               foreach (int element in lista)
               {
                   Console.Write(element + " ");
               }

               Console.WriteLine();
               //Napisz program, który wyświetla menu z pięcioma opcjami, co chcesz zrobić z listą:
               bool sprawdzacz = false;
               do
               {
                   Console.WriteLine("Wybierz coś 1 - Liczby Podzielne przez 3 lub 5; 2 - Lista liczb nieparzystych");
                   Console.WriteLine("3 - Liczby posortowane malejąco; 4 - Liczby posortowane rosnąco;");
                   Console.WriteLine("Cokolwiek innego by wyjsc");
                   int answer = int.Parse(Console.ReadLine());
                   //Wyświetlić listę liczb podzielnych przez 3 lub 5
                   if (answer == 1)
                   {
                       PodzielnePrzez3Lub5(lista);
                       Console.WriteLine();
                   }
                   //Wyświetlić listę liczb nieparzystych
                   else if (answer == 2)
                   {
                       niepodzielne(lista);
                       Console.WriteLine();
                   }
                   //Wyświetlić listę liczb posortowanych rosnąco
                   else if (answer == 3)
                   {
                       SortRosnaco(lista);
                       Console.WriteLine();
                   }
                   //Wyświetlić listę liczb posortowanych malejąco
                   else if (answer == 4)
                   {
                       SortMalejaco(lista);
                       Console.WriteLine();
                   }
                   //Wyjść z programu
                   else
                   {
                       sprawdzacz = true;
                   }
               } while (!sprawdzacz);
               //Napisz metodę dla każdej opcji, która przyjmuje jako parametr listę liczb i zwraca listę liczb spełniających warunek danej opcji.
               //Napisz kod, który obsługuje wybór użytkownika i wywołuje odpowiednią metodę, a następnie wyświetla wynikową listę na konsoli.
               //Napisz kod, który powtarza wyświetlanie menu i obsługę wyboru, dopóki użytkownik nie wybierze opcji wyjścia z programu.

        }
        public static List<int> PodzielnePrzez3Lub5(List<int> lista)
        {
            List<int> koniec = new List<int>();
            foreach (int element in lista)
            {
                if (element % 3 == 0 || element % 5 == 0)
                {
                    koniec.Add(element);
                }
            }
        
            foreach (var element in koniec)
            {
                Console.Write(element + " ");
            }
        
            return koniec;
        }

        public static List<int> niepodzielne(List<int> lista)
        {
            //Wyświetlić listę liczb nieparzystych
            List<int> koniec = new List<int>();
            foreach (int element in lista)
            {
                if (element % 2 != 0)
                {
                    koniec.Add(element);
                }
            }

            Console.WriteLine();
            foreach (var element in koniec)
            {
                Console.Write(element + " ");
            }
            return koniec;
        }

        public static List<int> SortRosnaco(List<int> lista)
        {
            lista.Sort();
            foreach (int element in lista)
            {
                Console.Write(element + " ");
            }
            return lista;
        }
        public static List<int> SortMalejaco(List<int> lista)
        {
            lista.Sort();
            lista.Reverse();
            foreach (int element in lista)
            {
                Console.Write(element + " ");
            }
            return lista;
        }
    }
}