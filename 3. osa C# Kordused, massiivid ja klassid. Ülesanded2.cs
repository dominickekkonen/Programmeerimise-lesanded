using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {

        }
        public static int[] GenereeriRuudud(int min,int max)
        {
            Random rnd = new Random();
            int N = rnd.Next(min, max + 1);
            int M = rnd.Next(min, max + 1);
            int start = Math.Min(N, M);
            int end = Math.Min(N, M);
            int[] masiiv = new int[end - start];
            for (int i = start; i <= end; i++)
            {
               int ruut = i + i;
               masiiv[i] = ruut;
            }

        }
        public static void arvuAnaluus()
        {
            double sum = 0;
            double korrutis = 1;
            double keskmine = 0;
            double[] arvud = new double[5];
            for(int i = 0; i < arvud.Length; i++)
            {
                Console.Write($"Sisesta {i + 1}. arv: ");
                arvud[i] = double.Parse(Console.ReadLine());
                korrutis *= arvud[i];
                sum += arvud[i];
            }
        }
        public static int[] Täida_massiiv(int[] arvud)
        {
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.Write($"Sisesta {i + 1}. arv: ");
                try
                {
                    arvud[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return arvud;
        }
    }
}



public class Ül3
{
    public static void Main(string[] arg)
    {
        //küsi mis positsioonil muuda element ja mis väärtuseks, muuda element ja kuva massiiv
        double arvud = Naidis_IKTpv25
        arvud = Ül3.TäidaMassiiv(arvud);
        Ül3.MuudaElementMasiivis(arvud);
        Ül3.Summa(arvud);
        

    }

    private static void Summa()
    {
        throw new NotImplementedException();
    }

    private static void MuudaElementMasiivis(int[] arvud)
    {
        Console.WriteLine("Kuhu: ");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Milliseks: ");
        int uusArv = int.Parse(Console.ReadLine());
        arvud[pos - 1] = uusArv;
        Console.WriteLine("Uuendatud massiiv: ");
        for (int i = 0; i < arvud.Length; i++)
        {
            Console.WriteLine($"Sisestanud arv: {arvud[i]}");
        }
    }

    private static double[] TäidaMassiiv(int[] arvud)
    {
        for (int i = 0; i < arvud.Length; i++)
        {
            Console.WriteLine($"Sisesta {i+1} arv: ")
            try 
        }
    }
}


