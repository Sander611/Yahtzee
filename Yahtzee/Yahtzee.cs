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

        


        public SpelBeheer SpelBeheer { get; set; }


        public Yahtzee()
        {
           
            InitializeComponent();

        }

        public void changePlayerLabel(string playerName)
        // Verandert label in form naar speler die aan de beurt is.
        {
            spelerNaamVeld.Text = playerName;
        }

        public void getListBoxes()
        // Haalt alle dobbelsteen pictureboxes(controls) op en stopt ze in lijst dobbelsteenBoxes in spelbeheer.
        {
            foreach (Control c in this.Controls)
            {
                var current = c as PictureBox;

                if (current != null)
                {
                    SpelBeheer.dobbelsteenBoxes.Add(current);
                }
            }
        }


        public void setupListWorpen(List<Speler> alleSpelers, List<string> alleWorpen)
        // Genereert listviews waarin alle worpsoorten staan.
        {
            List<ListView> worpLijsten = new List<ListView>() { worpenListBox, worpenListBox2 };

            foreach (ListView lv in worpLijsten)
            {
                lv.GridLines = true;
                lv.FullRowSelect = true;
                lv.Scrollable = true;
                lv.View = View.Details;

                lv.Columns.Add("Worpen", "Worpen", 120);

                for (int i = 0; i < alleSpelers.Count; i++)
			    {
                    lv.Columns.Add(alleSpelers[i].Naam, alleSpelers[i].Naam, -2);
			    }
                
            }

            for (int i = 0; i < 6; i++)
            {
                var items = new ListViewItem();
                items.Text = alleWorpen[i];
                for (int x = 0; x < alleSpelers.Count; x++)
                {
                    items.SubItems.Add("");
                }
                worpenListBox.Items.Add(items);
            }


            for (int i = 6; i < alleWorpen.Count; i++)
            {
                var items = new ListViewItem();
                items.Text = alleWorpen[i];
                for (int x = 0; x < alleSpelers.Count; x++)
                {
                    items.SubItems.Add("");
                }
                worpenListBox2.Items.Add(items);
            }
        }

            

        private void dobbelButton_Click(object sender, EventArgs e)
        // Deze functie pakt voor elke dobbelsteen box een random image (alleen voor de dobbelstenen die field (magRollen) true heeft.
        {
            SpelBeheer.currentSpeler.dobbelCounter += 1;
            foreach (Dobbelsteen dobbelsteen in SpelBeheer.DobbelstenenLijst)
            {
                if (dobbelsteen.magRollen)
                {

                    int index = SpelBeheer.randomGetal();
                    dobbelsteen.currWaarde = index;
                    dobbelsteen.setImage(SpelBeheer.DobbelstenenImages[index]);

                }
                else
                {
                    continue;
                }
            }
            if (SpelBeheer.currentSpeler.dobbelCounter == 3)
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


            if (SpelBeheer.currentSpeler.dobbelCounter >= 1)
            {
                endTurnButton.Enabled = true;
            }



        }

        private void endTurnButton_Click(object sender, EventArgs e)
        // Deze functie wordt uitgevoerd wanneer op de "end turn" knop geklikt wordt. Hierdoor worden functies aangeroepen in de YahtzeeRegels class die punten berekenen indien true.
        {
            var geselecteerdeWorp = worpenListBox.SelectedItems.Count > 0 ? worpenListBox.SelectedItems[0] : null;
            bool LVIngevuld = false;

            // TODO: if veld al ingevuld doe dit.
            if (geselecteerdeWorp == null)
            {
                geselecteerdeWorp = worpenListBox2.SelectedItems.Count > 0 ? worpenListBox2.SelectedItems[0] : null;
                if (geselecteerdeWorp == null)
                {
                    throw new ArgumentException("Beide geselecteerde worpen komen niet door (NULL)!!");
                }
                else
                {

                    LVIngevuld = SpelBeheer.calculateScoreAndUpdate(geselecteerdeWorp.Text, worpenListBox2);

                }
            }
            else
            {

                LVIngevuld = SpelBeheer.calculateScoreAndUpdate(geselecteerdeWorp.Text, worpenListBox);

            }
           

            if (!LVIngevuld) // als worp al ingevuld is moet de gebruiker een andere worp selecteren daarna kan pas geswitched worden naar de volgende speler o.i.d.
            {
                dobbelButton.Enabled = false;
                endTurnButton.Enabled = false;
                volgendeBeurt.Enabled = true;
            }

            

        }

        public bool replaceValueListView(int punten, ListView box, string rowName)
        // Deze functie update de score in de listviews. Wanneer de score in een row al ingevoerd is kan er niet worden overschreven.
        {
            var c_worpen = box.Columns["Worpen"].Index;
            var c_punten = box.Columns[SpelBeheer.currentSpeler.Naam].Index;

            bool alIngevuld = false;

            foreach (ListViewItem item in box.Items)
            {
                if (item.SubItems[c_worpen].Text == rowName)
                {
                    if (item.SubItems[c_punten].Text == "")
                    {
                        item.SubItems[c_punten].Text = Convert.ToString(punten);
                        SpelBeheer.currentSpeler.scoreKeeper[rowName] = punten;
                    }
                    else
                    {
                        alIngevuld = true;
                    }

                    break;
                    
                }
            }

            return alIngevuld;
        }

        private void volgendeBeurt_Click(object sender, EventArgs e)
        // Deze functie gaat door naar de volgende beurt
        {
            SpelBeheer.setupDobbelstenen();

            foreach (PictureBox pb in SpelBeheer.dobbelsteenBoxes)
            {
                pb.BorderStyle = BorderStyle.None;
            }

            SpelBeheer.checkVoorEindeSpel();

            SpelBeheer.currentSpeler.dobbelCounter = 0;

            SpelBeheer.getVolgendeSpeler();

            changePlayerLabel(SpelBeheer.currentSpeler.Naam);

            dobbelButton.Enabled = true;
            volgendeBeurt.Enabled = false;

        }

        private void dobbel_Click(object sender, EventArgs e)
        // Deze functie disabled dobbelstenen zodat ze niet meer gerolld kunnen worden.
        {
            if (SpelBeheer.currentSpeler.dobbelCounter >= 1)
            {
                var pb = sender as PictureBox;
                foreach (Dobbelsteen dobbelsteen in SpelBeheer.DobbelstenenLijst)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
