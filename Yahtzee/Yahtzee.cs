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
        Dictionary<int, string> DobbelstenenImages = new Dictionary<int, string>();
        private List<PictureBox> dobbelsteenBoxes = new List<PictureBox>() {};

        public List<Dobbelsteen> DobbelstenenLijst = new List<Dobbelsteen>();

       
        public Yahtzee()
        {
           
            InitializeComponent();
            getListBoxes();
            fillImageDict();
            setupDobbelstenen();
            setupListWorpen();
        }

        private void setupListWorpen()
        {
            //worpenListBox.CheckBoxes = true;
            worpenListBox.GridLines = true;
            worpenListBox.FullRowSelect = true;
            worpenListBox.Scrollable = true;
            worpenListBox.View = View.Details;

            //worpenListBox.OwnerDraw = true;
            worpenListBox.Columns.Add("Worpen", "Worpen", 200);
            worpenListBox.Columns.Add("Punten", "Punten", -2);

            for (int i = 0; i < 6; i++)
            {
                var items = new ListViewItem(new[] { alleWorpen[i], "" });
                worpenListBox.Items.Add(items);
            }

            ////////////////////////////////////

            //worpenListBox2.CheckBoxes = true;
            worpenListBox2.GridLines = true;
            worpenListBox2.FullRowSelect = true;
            worpenListBox2.Scrollable = true;
            worpenListBox2.View = View.Details;

            //worpenListBox.OwnerDraw = true;
            worpenListBox2.Columns.Add("Worpen", "Worpen", 200);
            
            worpenListBox2.Columns.Add("Punten", "Punten", -2);

            for (int i = 6; i < alleWorpen.Count; i++)
            {
                var items = new ListViewItem(new[] { alleWorpen[i], "" });
                worpenListBox2.Items.Add(items);
            }
        }
        
        private void getListBoxes()
        {
            foreach(Control c in this.Controls)
            {
                var current = c as PictureBox;

                if (current != null)
                {
                    dobbelsteenBoxes.Add(current);
                }
            }
        }
        private void fillImageDict()
        {
            for (int i = 1; i < 7; i++)
            {
                string imagePath = "../../images/dice" + i + ".png";
                DobbelstenenImages.Add(i, imagePath);
            }
        }

        private void setupDobbelstenen()
        {
            for (int i = 0; i < 5; i++)
            {
                Dobbelsteen dobbelsteen = new Dobbelsteen(i+1, DobbelstenenImages[i+1], dobbelsteenBoxes[i]);
                DobbelstenenLijst.Add(dobbelsteen);
            }
        }

        private void dobbelButton_Click(object sender, EventArgs e)
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
        {
            for (int i = 0; i < LVname.SelectedIndices.Count; i++)
            {
                LVname.Items[LVname.SelectedIndices[i]].Selected = false;
            }
        }

        private void ListBox_Click(object sender, EventArgs e)
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
                    dobbelButton.Enabled = false;
                    endTurnButton.Enabled = false;
                    dobbelCounter = 0;
                }
            }
            else
            {
                int toegekendePunten = yahtzeeRegels.PuntenBerekenen(geselecteerdeWorp.Text, DobbelstenenLijst);
                replaceValueListView(toegekendePunten, worpenListBox, geselecteerdeWorp.Text);
                dobbelButton.Enabled = false;
                endTurnButton.Enabled = false;
                dobbelCounter = 0;
            }

        }

        private void replaceValueListView(int punten, ListView box, string rowName)
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
        {
            // RESET dobbelstenen (image, currWaarde en magRollen) (omlijning verwijderen)
            // Enable dobble button
            
            
        }

        private void dobbel_Click(object sender, EventArgs e)
        {
            foreach (Dobbelsteen dobbelsteen in DobbelstenenLijst)
            {
                // check of dobblesteen property overeenkomt met eventsender object property oid
                // als dat zo is dan dobbelsteen.magRollen op false zetten.
                // dobbelsteen andere kleur geven? omlijning etc?
            }
        }
    }
}
