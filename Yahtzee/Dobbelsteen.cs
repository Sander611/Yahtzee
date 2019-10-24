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
    public class Dobbelsteen
    {
        public int currWaarde { get; set; }
        public int IdDobbelsteen { get; set; }

        public bool magRollen { get; set; }

        public PictureBox dobbelsBox { get; set; }

        public Dobbelsteen(int id, string startImage, PictureBox deBox)
        {
            IdDobbelsteen = id;
            magRollen = true;
            dobbelsBox = deBox;
            currWaarde = 0;

            setImage(startImage);
        }

        public void setImage (string displayImage) { 
            dobbelsBox.Load(displayImage);
            dobbelsBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }



    }
}
