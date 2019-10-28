using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Models;
using Yahtzee.Repositories;

namespace Yahtzee
{
    public class SpelBeheer

    {
        ScoreRepository scoreRepo = new ScoreRepository();
        ScoresTonen scoresForm = new ScoresTonen();
        private YahtzeeRegels yahtzeeRegels = new YahtzeeRegels();
        public Yahtzee yahtzeeForm;


        private List<string> alleWorpen = new List<string>() { "Enen", "Tweeën", "Drieën", "Vieren", "Vijfen", "Zessen", "Three of a kind", "Carré", "Full house", "Kleine straat", "Grote straat", "Super score", "Chance" };
        private List<Speler> alleSpelers = new List<Speler>();


        public Dictionary<int, string> DobbelstenenImages = new Dictionary<int, string>();
        public List<PictureBox> dobbelsteenBoxes = new List<PictureBox>() { };
        public List<Dobbelsteen> DobbelstenenLijst;


        Random rnd = new Random();

        //private int opslagDeel1Punten = 0;
        //private int opslagDeel2Punten = 0;

        public int welkeSpeler = 0;
        public int aantalLoops;
        public Speler currentSpeler;

        public void startSpel()
        {
            // speler label eerste speler zetten? 
            yahtzeeForm.changePlayerLabel(alleSpelers[0].Naam);
            currentSpeler = alleSpelers[0];

            // alle dobbelsteenboxen in lijst zetten (doen in Yahtzee en returnen?)
            yahtzeeForm.getListBoxes();

            // dictionary maken (key = punten, value = image path) voor elke dobbelsteen image
            fillImageDict();

            // dobbelstenen aanmaken en in lijst zetten
            setupDobbelstenen();

            // listviews vullen met lege data
            yahtzeeForm.setupListWorpen(alleSpelers, alleWorpen);

            aantalLoops = aantalLoopsBerekenen();

        }

        public void getVolgendeSpeler()
        // wisselt speler die aan de beurt is.
        {

            welkeSpeler += 1;

            if(welkeSpeler > alleSpelers.Count-1)
            {
                welkeSpeler = 0;
            }

            currentSpeler = alleSpelers[welkeSpeler];
        }

        private int aantalLoopsBerekenen()
        // berekent hoevaak het spel moet loopen.
        {
           
            return alleWorpen.Count * alleSpelers.Count;
        }

        public void spelersAanmaken(List<string> spelerNamenLijst)
        // Maakt voor aantal ingevoerde spelernamen een spelere klasse aan.
        {
            foreach (string spelerNaam in spelerNamenLijst)
            {
                Speler speler = new Speler(spelerNaam);
                alleSpelers.Add(speler);
                speler.scoreKeeperDefault(alleWorpen);
            }
        }

        private void fillImageDict()
        // Maakt een dictionary met als key de waarde van de dobbelsteen en als value de path naar de image file.
        {
            for (int i = 1; i < 7; i++)
            {
                string imagePath = "../../Images/dice" + i + ".png";
                DobbelstenenImages.Add(i, imagePath);
            }
        }

        public void setupDobbelstenen()
        // Vult een lijst met dobbelsteen objecten.
        {
            DobbelstenenLijst = new List<Dobbelsteen>();
            for (int i = 0; i < 5; i++)
            {
                Dobbelsteen dobbelsteen = new Dobbelsteen(i + 1, DobbelstenenImages[i + 1], dobbelsteenBoxes[i]);
                DobbelstenenLijst.Add(dobbelsteen);
            }
        }

        public int randomGetal()
        // genereert een random getal tussen (1 tot met 6).
        {
            return rnd.Next(1, 7);
        }

        public void calculateScoreAndUpdate(string geselecteerdeWorp, ListView listViewBox)
        // berekent score en update waardes en velden in form mbv andere functies.
        {

            int toegekendePunten = yahtzeeRegels.PuntenBerekenen(geselecteerdeWorp, DobbelstenenLijst);

            yahtzeeForm.replaceValueListView(toegekendePunten, listViewBox, geselecteerdeWorp);
            
        }

        public void checkVoorEindeSpel()
        // checked of elke speler alle worpen heeft ingevuld en update score van elke speler.
        {
            int totaalFinished = 0;
            foreach(Speler speler in alleSpelers)
            {
                int totaalIngevuld = 0;
                int scoreSpeler = 0;
                foreach (KeyValuePair<string, int?> entry in speler.scoreKeeper)
                {
                    if(entry.Value != null)
                    {
                        scoreSpeler += entry.Value.Value;
                        totaalIngevuld += 1;
                    }
                }

                speler.totaleScore = scoreSpeler;

                if(totaalIngevuld == alleWorpen.Count)
                {
                    totaalFinished += 1;
                }
            }


            if (totaalFinished == alleSpelers.Count)
            {
                eindigSpel();
            }

            
        }

        private void eindigSpel()
        // Exits the game en updated database.
        {
            

            addScoresToDb();

            string besteSpeler = getHighestScoreOfMatch();

            scoresForm.updateTitle(besteSpeler);

            spelerScoresIterator();

            getTopScores();

            scoresForm.Show();
            yahtzeeForm.Close();

        }

        private void getTopScores()
        // Krijgt een lijst met top 10 all time scores en laad die in listview via scoretonen form.
        {

            var scoreLijst = scoreRepo.GetTopList();
            foreach(Score score in scoreLijst)
            {
                scoresForm.UpdateAllTimeScores(score.NAAM, score.SCORE1);
            }

        }

        private void spelerScoresIterator()
        // Verstuurd alle spelernamen met hun scores van deze match naar de scorestonen form.
        {
            for (int i = 0; i < alleSpelers.Count; i++)
            {
                scoresForm.updateScoreFields(alleSpelers[i].Naam, alleSpelers[i].totaleScore, i);
                    
            }
        }

        private void addScoresToDb()
        //ADDING SCORE TO DATABASe:
        {

            foreach (Speler speler in alleSpelers)
            {
                var nieuwScoreObj = new Score
                {
                    NAAM = speler.Naam,
                    SCORE1 = speler.totaleScore

                };
                scoreRepo.AddNewScore(nieuwScoreObj);
            }
        }

        private string getHighestScoreOfMatch()
        // Krijgt highest score van deze match
        {
            string spelerNaam = "";

            var gewonnenSpeler = alleSpelers.OrderByDescending(i => i.totaleScore).Take(1);
            foreach(Speler speler in gewonnenSpeler)
            {
                spelerNaam = speler.Naam;
            }

            return spelerNaam;
        }


    }
}
