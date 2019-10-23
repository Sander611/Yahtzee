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
                    return 0;

                case "Carré":
                    return 0;

                case "Full house":
                    return 0;

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
            int teller = 0;
            bool klopt = false;
            for (int i = 1; i < lengte+1; i++)
            {
                for(int x = i; x < i+4; x++)
                {
                    if (lijst.Contains(x))
                    {
                        teller++;
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
                        aantal++;
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
