namespace Yahtzee
{
    partial class ScoresTonen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.highScoresLV = new System.Windows.Forms.ListView();
            this.labelSpeler1 = new System.Windows.Forms.Label();
            this.boxSpeler1 = new System.Windows.Forms.TextBox();
            this.boxSpeler2 = new System.Windows.Forms.TextBox();
            this.labelSpeler2 = new System.Windows.Forms.Label();
            this.boxSpeler3 = new System.Windows.Forms.TextBox();
            this.labelSpeler3 = new System.Windows.Forms.Label();
            this.boxSpeler4 = new System.Windows.Forms.TextBox();
            this.labelSpeler4 = new System.Windows.Forms.Label();
            this.winnaarLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // highScoresLV
            // 
            this.highScoresLV.HideSelection = false;
            this.highScoresLV.Location = new System.Drawing.Point(388, 144);
            this.highScoresLV.Name = "highScoresLV";
            this.highScoresLV.Size = new System.Drawing.Size(359, 285);
            this.highScoresLV.TabIndex = 0;
            this.highScoresLV.UseCompatibleStateImageBehavior = false;
            // 
            // labelSpeler1
            // 
            this.labelSpeler1.AutoSize = true;
            this.labelSpeler1.Location = new System.Drawing.Point(81, 176);
            this.labelSpeler1.Name = "labelSpeler1";
            this.labelSpeler1.Size = new System.Drawing.Size(57, 17);
            this.labelSpeler1.TabIndex = 1;
            this.labelSpeler1.Text = "Speler1";
            // 
            // boxSpeler1
            // 
            this.boxSpeler1.Location = new System.Drawing.Point(178, 176);
            this.boxSpeler1.Name = "boxSpeler1";
            this.boxSpeler1.ReadOnly = true;
            this.boxSpeler1.Size = new System.Drawing.Size(100, 22);
            this.boxSpeler1.TabIndex = 2;
            // 
            // boxSpeler2
            // 
            this.boxSpeler2.Location = new System.Drawing.Point(178, 230);
            this.boxSpeler2.Name = "boxSpeler2";
            this.boxSpeler2.ReadOnly = true;
            this.boxSpeler2.Size = new System.Drawing.Size(100, 22);
            this.boxSpeler2.TabIndex = 4;
            // 
            // labelSpeler2
            // 
            this.labelSpeler2.AutoSize = true;
            this.labelSpeler2.Location = new System.Drawing.Point(81, 230);
            this.labelSpeler2.Name = "labelSpeler2";
            this.labelSpeler2.Size = new System.Drawing.Size(57, 17);
            this.labelSpeler2.TabIndex = 3;
            this.labelSpeler2.Text = "Speler2";
            // 
            // boxSpeler3
            // 
            this.boxSpeler3.Location = new System.Drawing.Point(178, 290);
            this.boxSpeler3.Name = "boxSpeler3";
            this.boxSpeler3.ReadOnly = true;
            this.boxSpeler3.Size = new System.Drawing.Size(100, 22);
            this.boxSpeler3.TabIndex = 6;
            // 
            // labelSpeler3
            // 
            this.labelSpeler3.AutoSize = true;
            this.labelSpeler3.Location = new System.Drawing.Point(81, 290);
            this.labelSpeler3.Name = "labelSpeler3";
            this.labelSpeler3.Size = new System.Drawing.Size(57, 17);
            this.labelSpeler3.TabIndex = 5;
            this.labelSpeler3.Text = "Speler3";
            // 
            // boxSpeler4
            // 
            this.boxSpeler4.Location = new System.Drawing.Point(178, 349);
            this.boxSpeler4.Name = "boxSpeler4";
            this.boxSpeler4.ReadOnly = true;
            this.boxSpeler4.Size = new System.Drawing.Size(100, 22);
            this.boxSpeler4.TabIndex = 8;
            // 
            // labelSpeler4
            // 
            this.labelSpeler4.AutoSize = true;
            this.labelSpeler4.Location = new System.Drawing.Point(81, 349);
            this.labelSpeler4.Name = "labelSpeler4";
            this.labelSpeler4.Size = new System.Drawing.Size(57, 17);
            this.labelSpeler4.TabIndex = 7;
            this.labelSpeler4.Text = "Speler4";
            // 
            // winnaarLabel
            // 
            this.winnaarLabel.AutoSize = true;
            this.winnaarLabel.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnaarLabel.Location = new System.Drawing.Point(12, 9);
            this.winnaarLabel.Name = "winnaarLabel";
            this.winnaarLabel.Size = new System.Drawing.Size(365, 60);
            this.winnaarLabel.TabIndex = 9;
            this.winnaarLabel.Text = "Winnaar: [speler]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Top 10 scores:";
            // 
            // ScoresTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.winnaarLabel);
            this.Controls.Add(this.boxSpeler4);
            this.Controls.Add(this.labelSpeler4);
            this.Controls.Add(this.boxSpeler3);
            this.Controls.Add(this.labelSpeler3);
            this.Controls.Add(this.boxSpeler2);
            this.Controls.Add(this.labelSpeler2);
            this.Controls.Add(this.boxSpeler1);
            this.Controls.Add(this.labelSpeler1);
            this.Controls.Add(this.highScoresLV);
            this.Name = "ScoresTonen";
            this.Text = "ScoresTonen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView highScoresLV;
        private System.Windows.Forms.Label labelSpeler1;
        private System.Windows.Forms.TextBox boxSpeler1;
        private System.Windows.Forms.TextBox boxSpeler2;
        private System.Windows.Forms.Label labelSpeler2;
        private System.Windows.Forms.TextBox boxSpeler3;
        private System.Windows.Forms.Label labelSpeler3;
        private System.Windows.Forms.TextBox boxSpeler4;
        private System.Windows.Forms.Label labelSpeler4;
        private System.Windows.Forms.Label winnaarLabel;
        private System.Windows.Forms.Label label6;
    }
}