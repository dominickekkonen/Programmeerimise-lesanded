using Osa5;
using System.Collections;

namespace osa5
{
    public class osa5funktsioonid
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tee valik:\n0 - Välja\n1 - Näidis funktsioonid?\n2 - Kalooride kalkulaator\n");
            int valik = int.Parse(Console.ReadLine());
            switch(valik)
            {
                case 0:
                    Console.Clear();
                    break;
                case 1:
                    Osa5_Näidis_funktsioonid.Näidis_funktsioonid();
                    break;
                case 2:
                    Osa5_Näidis_funktsioonid.KaloorideKalkulaator();
                    break;
                default:
                    Console.WriteLine("Vali midagi");
                    break;
            }

        }
    }
}
