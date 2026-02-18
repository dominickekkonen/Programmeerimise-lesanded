namespace konstruktsionid_ülesanded
{
        public class StartPage
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Tere, mis on sinu nimi?: ");
                string eesnimi = "";
                eesnimi = Console.ReadLine();
                do
                {
                    Console.WriteLine("Mis on sinu vanus?: ");
                    int vanus = 0;
                    vanus = int.Parse(Console.ReadLine());
                    if (vanus >= 6)
                    {
                        Console.WriteLine("piletid on tasuta");
                    }
                    else if (vanus <= 7 && vanus >= 14)
                    {
                        Console.WriteLine("see on lastepilet");
                    }
                    else if (vanus <= 15 && vanus >= 65)
                    {
                        Console.WriteLine("see on täispilet");
                    }
                    else if (vanus <= 66)
                    {
                        Console.WriteLine("sul on soosduspilet");
                    }
                    else if (vanus <= 0 && vanus >= 100)
                    {
                        Console.WriteLine("Viga");
                    }
                } while (eesnimi == "jukku");

            }
        }
}
