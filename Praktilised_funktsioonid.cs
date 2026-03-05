using System;
using System.Collections.Generic;
using System.Text;

namespace Osa._4_Praktilised_ülesannded
{
    public static class Praktilised_funktsioonid
    {
        public static void LaeKoostisosad()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
            List<string> koostisosad = new List<string>();

            try
            {
                string[] read = File.ReadAllLines(failitee);
                koostisosad = new List<string>(read);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void salvestamine_faili()
        {
            Console.Write("Sisesta üks Itaalia toit: ");
            string toit = Console.ReadLine();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");

            try
            {
                StreamWriter writer = new StreamWriter(path, true);
                writer.WriteLine(toit);
                writer.Close();

                Console.WriteLine("Toit salvestati edukalt faili!");
            }
            catch (Exception)
            {
                Console.WriteLine("Faili kirjutamisel tekkis viga");
            }

        }
        public static void Koostisosade_muutmine()
        {
            string path = "Koostisosad.txt";

            List<string> koostisosad = new List<string>(File.ReadAllLines(path));

            koostisosad[0] = "Kvaliteetne oliiviõli";

            koostisosad.Remove("Ketšup");

            Console.WriteLine("Uuendatud koostisosade nimekiri:");

            foreach (string i in koostisosad)
            {
                Console.WriteLine(i);
            }
        }
        public static void Külmkappi_kontroll(List<string> koostisosad)
        {
            Console.Write("\nSisesta koostisosa, mida otsida: ");
            string otsitav = Console.ReadLine();

            if (koostisosad.Contains(otsitav))
            {
                Console.WriteLine("Koostisosa on olemas!");
            }
            else
            {
                Console.WriteLine("Seda koostisosa meil retseptis ei ole.");
            }
            File.WriteAllLines("Koostisosad.txt", koostisosad);

            Console.WriteLine("Uus retsept on edukalt faili salvestatud!");
        }

    }
}
