using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{

    public partial class Yahtzee : Form
    {

        YahtzeeRegels yahtzeeRegels = new YahtzeeRegels();
        int dobbelCounter = 0;
        Random rnd = new Random();

        private List<string> alleWorpen = new List<string>() { "Enen", "Tweeën", "Drieën", "Vieren", "Vijfen", "Zessen", "Three of a kind", "Carré", "Full house", "Kleine straat", "Grote straat", "Super score", "Chance" };

        private Dictionary<string, int> scoreKeeper = new Dictionary<string, int>();

        private int opslagDeel1Punten = 0;
        private int opslagDeel2Punten = 0;

        Dictionary<int, string> DobbelstenenImages = new Dictionary<int, string>();
        private List<PictureBox> dobbelsteenBoxes = new List<PictureBox>() {};

        public List<Dobbelsteen> DobbelstenenLijst;

       
        public Yahtzee()
        {
           
            InitializeComponent();

            // Vraag aantal spelers op
            // Vraag namen op voor het aantal spelers
            // Creeer speler objecten
            // maak voor elke speler een eigen scoreKeeper aan

            getListBoxes();
            fillImageDict();
            fillscoreKeeper();
            setupDobbelstenen();
            setupListWorpen();



        }

        private void getListBoxes()
        // Haalt alle dobbelsteen pictureboxes(controls) op en stopt ze in lijst dobbelsteenBoxes.
        {
            foreach (Control c in this.Controls)
            {
                var current = c as PictureBox;

                if (current != null)
                {
                    dobbelsteenBoxes.Add(current);
                }
            }
        }

        private void fillImageDict()
        // Maakt een dictionary met als key de waarde van de dobbelsteen en als value de path naar de image file.
        {
            for (int i = 1; i < 7; i++)
            {
                string imagePath = "../../images/dice" + i + ".png";
                DobbelstenenImages.Add(i, imagePath);
            }
        }

        private void fillscoreKeeper()
        // Maakt een dictionary voor de speler die bijhoudt welke worpen de gebruiker gebruikt heeft en de score bij elke worp (default value 0).
        // !!!
        // DEZE FUNCTIE MOET ELKE SPELER HEBBEN.
        // !!!
        {
            foreach (String worp in alleWorpen)
            {
                scoreKeeper.Add(worp, 0);
            }
        }

        private void setupDobbelstenen()
        // Vult een lijst met dobbelsteen objecten.
        {
            DobbelstenenLijst = new List<Dobbelsteen>();
            for (int i = 0; i < 5; i++)
            {
                Dobbelsteen dobbelsteen = new Dobbelsteen(i + 1, DobbelstenenImages[i + 1], dobbelsteenBoxes[i]);
                DobbelstenenLijst.Add(dobbelsteen);
            }
        }

        private void setupListWorpen()
        // Genereert listviews waarin alle worpsoorten staan.
        // !!!
        // DEZE FUNCTIE MOET TWEE KOLOMMEN KRIJGEN VOOR BEIDE SPELERS 1.
        // !!!
        {
            List<ListView> worpLijsten = new List<ListView>() { worpenListBox, worpenListBox2 };

            foreach (ListView lv in worpLijsten)
            {
                lv.GridLines = true;
                lv.FullRowSelect = true;
                lv.Scrollable = true;
                lv.View = View.Details;

                lv.Columns.Add("Worpen", "Worpen", 200);
                lv.Columns.Add("Punten", "Punten", -2);
            }

            for (int i = 0; i < 6; i++)
            {
                var items = new ListViewItem(new[] { alleWorpen[i], "" });
                worpenListBox.Items.Add(items);
            }


            for (int i = 6; i < alleWorpen.Count; i++)
            {
                var items = new ListViewItem(new[] { alleWorpen[i], "" });
                worpenListBox2.Items.Add(items);
            }
        }

///////////////////////////////////////////////////////////


        private void updateTotaalFields(int start, int tot, string deel)
        // Deze functie updated de totaalscorefields wanneer er een score wordt toegevoegd aan de listview.
        // !!!
        // DEZE FUNCTIE MOET ELKE SPELER HEBBEN.
        // !!!
        {
            int totaalPunten = 0;
            for (int i = start; i < tot; i++)
            {
                totaalPunten += scoreKeeper[alleWorpen[i]];
            }

            if(deel == "deel1")
            {
                if(totaalPunten >= 63)
                {
                    bonusTextBox.Text = "35";
                    totaalPunten += 35;
                }
                deel1TextBox.Text = Convert.ToString(totaalPunten);
                opslagDeel1Punten = totaalPunten;

                deel2TextBox.Text = Convert.ToString(opslagDeel2Punten + opslagDeel1Punten);
               
            }
            else
            {
                opslagDeel2Punten = totaalPunten + opslagDeel1Punten;
                deel2TextBox.Text = Convert.ToString(opslagDeel2Punten);
            }
            

        }

        private void dobbelButton_Click(object sender, EventArgs e)
        // Deze functie pakt voor elke dobbelsteen box een random image (alleen voor de dobbelstenen die field (magRollen) true heeft.
        {
            dobbelCounter++;
            foreach (Dobbelsteen dobbelsteen in DobbelstenenLijst)
            {
                if (dobbelsteen.magRollen)
                {
                    
                    int index = rnd.Next(1, 7);
                    dobbelsteen.currWaarde = index;
                    dobbelsteen.setImage(DobbelstenenImages[index]);
                    
                }
                else
                {
                    continue;
                }
            }
            if (dobbelCounter == 3)
            {
                dobbelButton.Enabled = false;
            }



        }

        private void unselectIndices (ListView LVname)
        // Deze functie haalt de blauwe selectie balk weg uit de listview.
        {
            for (int i = 0; i < LVname.SelectedIndices.Count; i++)
            {
                LVname.Items[LVname.SelectedIndices[i]].Selected = false;
            }
        }

        private void ListBox_Click(object sender, EventArgs e)
        // Deze functie haalt de geselecteerde worp op en zorgt dat er maar 1 worp tegelijkertijd geselecteerd kan worden.
        {
            string listViewName = ((ListView)sender).Name;
            if (listViewName == "worpenListBox")
            {
                unselectIndices(worpenListBox2);//DEEL2 uit selecteren
            }
            else
            {
                unselectIndices(worpenListBox);//DEEL1 uit selecteren
            }


            if(dobbelCounter >= 1)
            {
                endTurnButton.Enabled = true;
            }
            

            
        }

        private void endTurnButton_Click(object sender, EventArgs e)
        // Deze functie wordt uitgevoerd wanneer op de "end turn" knop geklikt wordt. Hierdoor worden functies aangeroepen in de YahtzeeRegels class die punten berekenen indien true.
        {
            var geselecteerdeWorp = worpenListBox.SelectedItems.Count > 0 ? worpenListBox.SelectedItems[0] : null;

            if (geselecteerdeWorp == null)
            {
                geselecteerdeWorp = worpenListBox2.SelectedItems.Count > 0 ? worpenListBox2.SelectedItems[0] : null;
                if (geselecteerdeWorp == null)
                {
                    throw new System.ArgumentException("Beide geselecteerde worpen komen niet door (NULL)!!");
                }
                else
                {

                    int toegekendePunten = yahtzeeRegels.PuntenBerekenen(geselecteerdeWorp.Text, DobbelstenenLijst);
                    replaceValueListView(toegekendePunten, worpenListBox2, geselecteerdeWorp.Text);
                    scoreKeeper[geselecteerdeWorp.Text] = toegekendePunten;
                    updateTotaalFields(6, alleWorpen.Count, "deel2");
                }
            }
            else
            {
                int toegekendePunten = yahtzeeRegels.PuntenBerekenen(geselecteerdeWorp.Text, DobbelstenenLijst);
                replaceValueListView(toegekendePunten, worpenListBox, geselecteerdeWorp.Text);
                scoreKeeper[geselecteerdeWorp.Text] = toegekendePunten;
                updateTotaalFields(0, 6, "deel1");
            }

            
            dobbelButton.Enabled = false;
            endTurnButton.Enabled = false;
            dobbelCounter = 0;
            volgendeBeurt.Enabled = true;

        }

        private void replaceValueListView(int punten, ListView box, string rowName)
        // Deze functie update de score in de listviews. Wanneer de score in een row al ingevoerd is kan er niet worden overschreven.
        {
            var c_worpen = box.Columns["Worpen"].Index;
            var c_punten = box.Columns["Punten"].Index;
            
            foreach (ListViewItem item in box.Items)
            {
                if (item.SubItems[c_worpen].Text == rowName)
                {
                    if (item.SubItems[c_punten].Text == "")
                    {
                        item.SubItems[c_punten].Text = Convert.ToString(punten);
                    }
                    
                    break;
                }
            }
        }

        private void volgendeBeurt_Click(object sender, EventArgs e)
        // Deze functie gaat door naar de volgende beurt
        // !!!
        // DEZE FUNCTIE MOET SPELERS SWITCHEN.
        // !!!
        {
            setupDobbelstenen();
            foreach(PictureBox pb in dobbelsteenBoxes)
            {
                pb.BorderStyle = BorderStyle.None;
            }

            dobbelButton.Enabled = true;
            volgendeBeurt.Enabled = false;
            
        }

        private void dobbel_Click(object sender, EventArgs e)
        // Deze functie disabled dobbelstenen zodat ze niet meer gerolld kunnen worden.
        {
            if (dobbelCounter >= 1)
            {
                var pb = sender as PictureBox;
                foreach (Dobbelsteen dobbelsteen in DobbelstenenLijst)
                {
                    if (pb == dobbelsteen.dobbelsBox)
                    {
                        if (pb.BorderStyle == BorderStyle.None)
                        {
                            dobbelsteen.magRollen = false;
                            pb.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            dobbelsteen.magRollen = true;
                            pb.BorderStyle = BorderStyle.None;

                        }

                    }
                }
            }

        }
    }
}
