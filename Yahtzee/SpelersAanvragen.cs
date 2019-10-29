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
    public partial class SpelersAanvragen : Form
    {
        private List<TextBox> naamInvoerBoxes;
        private List<Label> naamLabels;
        private SpelBeheer spel = new SpelBeheer();

        public SpelersAanvragen()
        {
            InitializeComponent();
            naamInvoerBoxes = new List<TextBox>() { naamBox1, naamBox2, naamBox3, naamBox4 };
            naamLabels = new List<Label>() { naamLabel1, naamLabel2, naamLabel3, naamLabel4 };

           
        }


        private void naarSpel_Click(object sender, EventArgs e)
        // Checkt of er meer dan 1 naam is toegevoegd en start speel scherm.
        {
            int naamCount = 0;
            List<string> namenSpelers = new List<string>() { };

            foreach(TextBox box in naamInvoerBoxes)
            {

                if (box.Text != "")
                {
                    naamCount += 1;
                    namenSpelers.Add(box.Text);
                }
            }

            if (namenSpelers.Count > 0)
            {
                spel.spelersAanmaken(namenSpelers);
                Yahtzee yahtzeeForm = new Yahtzee();
                spel.yahtzeeForm = yahtzeeForm;
                yahtzeeForm.SpelBeheer = spel;
                spel.startSpel();
                yahtzeeForm.Show();
                this.Hide();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        // Haalt aantal spelers op en afhankelijk daarvan toont invoervelden.
        {

            int aantal = Convert.ToInt32(numericUpDown1.Value);
            if (aantal == 0)
            {
                naarSpel.Enabled = false;
                for (int i = 0; i < naamInvoerBoxes.Count; i++)
                {
                    naamInvoerBoxes[i].Visible = false;
                    naamLabels[i].Visible = false;
                }
            }
            else
            {
                loopOverFields(naamInvoerBoxes, naamLabels, aantal);
                naarSpel.Enabled = true;
            }
        }

        private void loopOverFields(List<TextBox> boxes, List<Label> labels, int nr)
        // Laat boxen en labels zien voor het aantal spelers.
        {
            for (int i = 0; i < 4; i++)
            {
                if (i+1 <= nr)
                {
                    boxes[i].Visible = true;
                    labels[i].Visible = true;
                }
                else
                {
                    boxes[i].Visible = false;
                    labels[i].Visible = false;
                    boxes[i].Text = "";
                    boxes[i].Text = "";
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
