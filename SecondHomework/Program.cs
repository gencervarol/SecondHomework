using System;

namespace SecondHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> team = new Dictionary<int, string>();

            team.Add(20, "Gustavo");
            team.Add(27, "Mame Thiam");
            team.Add(41, "Attila Szalai");
            team.Add(8, "Mert Hakan Yandaş");
            team.Add(7, "Ozan Tufan");
            team.Add(5, "Sosa");


            team.ToList();



        }
    }
}
