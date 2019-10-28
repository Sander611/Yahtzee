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
    public partial class ScoresTonen : Form
    {
        private List<TextBox> scoreBoxes;
        private List<Label> scoreLabels;
        int counter = 0;

        public ScoresTonen()
        {
            InitializeComponent();
            scoreBoxes = new List<TextBox>() { boxSpeler1 , boxSpeler2, boxSpeler3, boxSpeler4};
            scoreLabels = new List<Label>() { labelSpeler1, labelSpeler2, labelSpeler3, labelSpeler4};

            makeEmptyTable();

        }

        private void makeEmptyTable()
        {
            highScoresLV.GridLines = true;
            highScoresLV.Scrollable = true;
            highScoresLV.View = View.Details;

            highScoresLV.Columns.Add("#", "#", -2);
            highScoresLV.Columns.Add("Name", "Name", 120);
            highScoresLV.Columns.Add("Score", "Score", 80);
            
        }

        public void updateScoreFields(string naam, int score, int index)
        {
            scoreBoxes[index].Text = score.ToString();
            scoreLabels[index].Text = naam;
        }


        public void updateTitle(string naam)
        {
            winnaarLabel.Text = "Winnaar: " + naam + "!";
        }


        public void UpdateAllTimeScores(string naam, int score)
        {
            ListViewItem item = highScoresLV.Items.Add((++counter).ToString());
            item.SubItems.Add(naam);
            item.SubItems.Add(score.ToString());

        }
    }
}
