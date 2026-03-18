using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace Osa5
{
    internal class Osa5_Näidis_funktsioonid
    {
        public static void Näidis_funktsioonid()
        {
            //ArrayList (System.Collections)
            //Näide
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");


            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
            //Tuple(järjendid)
            //Näide
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");

            //3
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);
            //Add/Remove/Insert
            List<string> people1 = new List<string>() { "Kadi", "Mirje" };
            people1.Add("Kadi");
            people1.Remove("Mirje");
            people.RemoveAt(0);
            people1.Insert(0, "Lisa");
            people.Sort();

            //AddRange
            List<Person> new_people = new List<Person>();
            new_people.Add(new Person() { Name = "Martin" });
            new_people.Add(new Person() { Name = "Nika" });
            people.AddRange(new_people);
            //Sort
            var People = people.OrderBy(p => p.Name).ToList();
            //Index
            int index = 1;
            Person newPerson = new Person { Name = "Karl" };

            // Increase list size by adding a dummy element
            people.Add(null);

            // Shift elements to the right
            for (int i = people.Count - 1; i > index; i--)
            {
                people[i] = people[i - 1];
            }

            // Insert new element
            people[index] = newPerson;
            //BinarySearch
            int BinarySearchByName(List<Person> list, string target)
            {
                int left = 0;
                int right = list.Count - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;

                    int comparison = string.Compare(list[mid].Name, target);

                    if (comparison == 0)
                    {
                        return mid; // found
                    }
                    else if (comparison < 0)
                    {
                        left = mid + 1; // search right half
                    }
                    else
                    {
                        right = mid - 1; // search left half
                    }
                }

                return -1; // not found
            }
            //4. LinkedList (System.Collections.Generic)
            //Näide
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);
            Console.WriteLine("================");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);
            LinkedListNode<int> a = loetelu.Find(5);
            loetelu.AddBefore(a, 11);
            loetelu.AddAfter(a, 22);
            Console.WriteLine("================");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);
            //Dictionary < TKey, TValue > – Sõnastik
            //Ńäidis
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);
        }
        public static void KaloorideKalkulaator()
        {
            List<Toode> tooted = new List<Toode>
        {
            new Toode { Nimi = "Kana", Kalorid100g = 165 },
            new Toode { Nimi = "Riis", Kalorid100g = 130 },
            new Toode { Nimi = "Õun", Kalorid100g = 52 },
            new Toode { Nimi = "Leib", Kalorid100g = 250 }
        };

            Inimene inimene = new Inimene();

            Console.Write("Nimi: ");
            inimene.Nimi = Console.ReadLine();

            Console.Write("Vanus: ");
            inimene.Vanus = int.Parse(Console.ReadLine());

            Console.Write("Sugu (M/N): ");
            inimene.Sugu = Console.ReadLine();

            Console.Write("Pikkus (cm): ");
            inimene.Pikkuscm = double.Parse(Console.ReadLine());

            Console.Write("Kaal (kg): ");
            inimene.Kaalkg = double.Parse(Console.ReadLine());

            Console.WriteLine("Aktiivsustase:");
            Console.WriteLine("1,2 - Vähe aktiivne");
            Console.WriteLine("1,55 - Keskmine");
            Console.WriteLine("1,9 - Väga aktiivne");
            inimene.Aktiivsustase = double.Parse(Console.ReadLine());

            
            double bmr;

            if (inimene.Sugu.ToUpper() == "M")
            {
                bmr = 88.36 + (13.4 * inimene.Kaalkg) + (4.8 * inimene.Pikkuscm) - (5.7 * inimene.Vanus);
            }
            else
            {
                bmr = 447.6 + (9.2 * inimene.Kaalkg) + (3.1 * inimene.Pikkuscm) - (4.3 * inimene.Vanus);
            }

            double kalorivajadus = bmr * inimene.Aktiivsustase;

            Console.WriteLine($"\nPäevane kalorivajadus: {kalorivajadus:F2} kcal\n");

            Console.WriteLine("Soovituslikud toidukogused:");

            foreach (var toode in tooted)
            {
                double grammid = (kalorivajadus / toode.Kalorid100g) * 100;

                Console.WriteLine($"{toode.Nimi}: {grammid:F2} g päevas");
            }
        }
    }
}
