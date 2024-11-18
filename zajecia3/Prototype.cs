using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyWorld
{
    public class Ork
    {
        public string Imie { get; set; }
        public int Sila { get; set; }
        public int Wytrzymalosc { get; set; }

        public override string ToString()
        {
            return $"Imię: {Imie}, Siła: {Sila}, Wytrzymałość: {Wytrzymalosc}";
        }
    }

    public class Prototype
    {
        public static void Main(string[] args)
        {
            var oryginalnyOrk = new Ork
            {
                Imie = "Gorbag",
                Sila = 50,
                Wytrzymalosc = 70
            };

            var orkowie = new List<Ork>();
            var random = new Random();

            for (int i = 0; i < 5; i++)
            {
                string serializedOrk = JsonConvert.SerializeObject(oryginalnyOrk);
                var klon = JsonConvert.DeserializeObject<Ork>(serializedOrk);

                if (klon != null)
                {
                    klon.Sila = random.Next(30, 100);
                    klon.Imie += $"_{i + 1}";
                    orkowie.Add(klon);
                }
            }

            foreach (var ork in orkowie)
            {
                Console.WriteLine(ork);
            }
        }
    }
}
