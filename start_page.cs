using System;
using System.IO;
namespace Osa._4_Praktilised_ülesannded
{
    internal class start_page
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Vali tegevus: \n0 - Välju\n1 - Koostisosade muutmine\n2 - Salvestamine faili\n3 - Külmkappi kontroll\n");
                int valik = int.Parse(Console.ReadLine());
                switch (valik)
                {
                    default:
                        break;
                    case 0:
                        Console.Clear(); ;
                        return;
                    case 1:
                        Praktilised_funktsioonid.Koostisosade_muutmine();
                        break;
                    case 2:
                        Praktilised_funktsioonid.salvestamine_faili();
                        break;
                    case 3:
                        Praktilised_funktsioonid.Külmkappi_kontroll();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
}
