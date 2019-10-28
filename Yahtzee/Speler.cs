using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Speler
    {
        public string Naam { get; set; }
        public Dictionary<string, int?> scoreKeeper = new Dictionary<string, int?>();
        public int dobbelCounter;
        public int totaleScore { get; set; }

        public Speler(string naam)
        {
            Naam = naam;
            dobbelCounter = 0;
        }

        public void scoreKeeperDefault(List<string> alleWorpen)
        // Maakt een dictionary voor de speler die bijhoudt welke worpen de gebruiker gebruikt heeft en de score bij elke worp (default value 0).
        {
            foreach (String worp in alleWorpen)
            {
                scoreKeeper.Add(worp, null);
            }
        }
    }
}
