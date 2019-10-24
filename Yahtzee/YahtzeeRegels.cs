using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class YahtzeeRegels
    {
        public int PuntenBerekenen(string worp, List<Dobbelsteen> dobbelstenenlijst)
        {
            int aantalPunten = 0;

            switch(worp)
            {
                case "Enen":
                    return berekenAantalZelfdeVoorNummer(dobbelstenenlijst, 1);

                case "Tweeën":
                    return berekenAantalZelfdeVoorNummer(dobbelstenenlijst, 2);

                case "Drieën":
                    return berekenAantalZelfdeVoorNummer(dobbelstenenlijst, 3);

                case "Vieren":
                    return berekenAantalZelfdeVoorNummer(dobbelstenenlijst, 4);

                case "Vijfen":
                    return berekenAantalZelfdeVoorNummer(dobbelstenenlijst, 5);

                case "Zessen":
                    return berekenAantalZelfdeVoorNummer(dobbelstenenlijst, 6);

                case "Three of a kind":
                    return berekenCarreOfThree(dobbelstenenlijst, "toak");

                case "Carré":
                    return berekenCarreOfThree(dobbelstenenlijst, "carre");

                case "Full house":
                    return berekenFullHouse(dobbelstenenlijst);

                case "Kleine straat":
                    return straatBerekenen(dobbelstenenlijst, "kleine");

                case "Grote straat":
                    return straatBerekenen(dobbelstenenlijst, "grote");

                case "Super score":
                    return superScoreBerekenen(dobbelstenenlijst); 

                case "Chance":
                    return chanceBerekenen(dobbelstenenlijst);
            }

            return aantalPunten;
        }

        private int berekenFullHouse(List<Dobbelsteen> dobbelLijst)
        {
            List<int> alleWaardes = new List<int>();
            int puntenTeller = 0;
            bool drieDezelfde = false;
            bool tweeDezelfde = false;

            foreach (Dobbelsteen dobbelsteen in dobbelLijst)
            {
                alleWaardes.Add(dobbelsteen.currWaarde);
            }

            var counts = alleWaardes.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            foreach (KeyValuePair<int, int> entry in counts)
            {
                if(entry.Value == 2)
                {
                    tweeDezelfde = true;
                }
                else if (entry.Value == 3)
                {
                    drieDezelfde = true;
                }
            }

            if (tweeDezelfde && drieDezelfde)
            {
                puntenTeller = 25;
            }

            return puntenTeller;
        }
        private int berekenCarreOfThree(List<Dobbelsteen> dobbelLijst, string checkWorp){

            List<int> alleWaardes = new List<int>();
            int puntenHouder = 0;
            int aantalPunten = 0;

            foreach (Dobbelsteen dobbelsteen in dobbelLijst)
            {
                puntenHouder += dobbelsteen.currWaarde;
                alleWaardes.Add(dobbelsteen.currWaarde);
            }

            var counts = alleWaardes.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            foreach(KeyValuePair<int, int> entry in counts){
                if (entry.Value == 3 && checkWorp == "toak"){ // three of a kind
                    aantalPunten = puntenHouder;
                }
                else if (entry.Value == 4 && checkWorp == "carre"){ // carré
                    aantalPunten = puntenHouder;
                }
            }

            return aantalPunten;


        }

        private int berekenAantalZelfdeVoorNummer(List<Dobbelsteen> dobbelLijst, int checkGetal)
        {
            int aantalPunten = 0;

            foreach (Dobbelsteen dobbelsteen in dobbelLijst)
            {
                if (dobbelsteen.currWaarde == checkGetal)
                {
                    aantalPunten += dobbelsteen.currWaarde;
                }
            }

            return aantalPunten;
        }
        
        private bool volgordeCheck(int lengte, List<int> lijst, int aantalGoed)
        {
            lijst.Sort();
            lijst = lijst.Distinct().ToList(); // gesorteerde unieke lijst
 
            int teller = 0;
            bool klopt = false;
            for (int i = 1; i < lengte+1; i++)
            {
                teller = 0;
                for (int x = i; x < i+aantalGoed; x++)
                {
                    if (lijst.Contains(x))
                    {
                        teller = teller + 1;
                    }
                }
                if (teller == aantalGoed)
                {
                    klopt = true;
                    break;
                }
            }

            return klopt;
        }
        private int straatBerekenen(List<Dobbelsteen> dobbelLijst, string typeStraat)
        {
            List<int> alleWaardes = new List<int>();
            int aantalPunten = 0;

            foreach (Dobbelsteen dobbelsteen in dobbelLijst)
            {
                alleWaardes.Add(dobbelsteen.currWaarde);
            }

            if (typeStraat == "kleine")
            {

                bool straat = volgordeCheck(3, alleWaardes, 4);
                aantalPunten = (straat) ? 30 : 0;

            }
            else if (typeStraat == "grote")
            {
                bool straat = volgordeCheck(2, alleWaardes, 5);
                aantalPunten = (straat) ? 40 : 0;
            }

            return aantalPunten;
        }
        private int superScoreBerekenen(List<Dobbelsteen> dobbelLijst)
        {
            int aantal = 0;
            for (int i = 1; i < 7 ; i++)
            {

                foreach (Dobbelsteen dobbelsteen in dobbelLijst)
                {

                    if (dobbelsteen.currWaarde == i)
                    {
                        aantal += 1;
                    }
                    
                }
                if (aantal == 5)
                {

                    break;
                }
                else
                {
                    aantal = 0;
                }
            }

            if (aantal == 5)
            {
                return 50;
            }
            else
            {
                return 0;
            }
            
        }
        private int chanceBerekenen(List<Dobbelsteen>dobbelLijst)
        {
            int totaal = 0;
            foreach(Dobbelsteen dobbelsteen in dobbelLijst)
            {
                totaal += dobbelsteen.currWaarde;
            }
            return totaal;

        }
    }
}
