namespace Yahtzee
{
    partial class SpelersAanvragen
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
            this.naarSpel = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.naamLabel2 = new System.Windows.Forms.Label();
            this.naamBox2 = new System.Windows.Forms.TextBox();
            this.naamBox3 = new System.Windows.Forms.TextBox();
            this.naamLabel3 = new System.Windows.Forms.Label();
            this.naamBox4 = new System.Windows.Forms.TextBox();
            this.naamLabel4 = new System.Windows.Forms.Label();
            this.naamBox1 = new System.Windows.Forms.TextBox();
            this.naamLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // naarSpel
            // 
            this.naarSpel.BackColor = System.Drawing.Color.White;
            this.naarSpel.Enabled = false;
            this.naarSpel.ForeColor = System.Drawing.Color.Red;
            this.naarSpel.Location = new System.Drawing.Point(101, 300);
            this.naarSpel.Name = "naarSpel";
            this.naarSpel.Size = new System.Drawing.Size(125, 26);
            this.naarSpel.TabIndex = 0;
            this.naarSpel.Text = "Naar spel";
            this.naarSpel.UseVisualStyleBackColor = false;
            this.naarSpel.Click += new System.EventHandler(this.naarSpel_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(171, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aantal Spelers:";
            // 
            // naamLabel2
            // 
            this.naamLabel2.AutoSize = true;
            this.naamLabel2.BackColor = System.Drawing.Color.Red;
            this.naamLabel2.ForeColor = System.Drawing.Color.White;
            this.naamLabel2.Location = new System.Drawing.Point(61, 143);
            this.naamLabel2.Name = "naamLabel2";
            this.naamLabel2.Size = new System.Drawing.Size(104, 17);
            this.naamLabel2.TabIndex = 3;
            this.naamLabel2.Text = "Naam speler2: ";
            this.naamLabel2.Visible = false;
            // 
            // naamBox2
            // 
            this.naamBox2.Location = new System.Drawing.Point(171, 140);
            this.naamBox2.Name = "naamBox2";
            this.naamBox2.Size = new System.Drawing.Size(104, 22);
            this.naamBox2.TabIndex = 4;
            this.naamBox2.Visible = false;
            // 
            // naamBox3
            // 
            this.naamBox3.Location = new System.Drawing.Point(171, 190);
            this.naamBox3.Name = "naamBox3";
            this.naamBox3.Size = new System.Drawing.Size(104, 22);
            this.naamBox3.TabIndex = 6;
            this.naamBox3.Visible = false;
            // 
            // naamLabel3
            // 
            this.naamLabel3.AutoSize = true;
            this.naamLabel3.BackColor = System.Drawing.Color.Red;
            this.naamLabel3.ForeColor = System.Drawing.Color.White;
            this.naamLabel3.Location = new System.Drawing.Point(61, 193);
            this.naamLabel3.Name = "naamLabel3";
            this.naamLabel3.Size = new System.Drawing.Size(104, 17);
            this.naamLabel3.TabIndex = 5;
            this.naamLabel3.Text = "Naam speler3: ";
            this.naamLabel3.Visible = false;
            // 
            // naamBox4
            // 
            this.naamBox4.Location = new System.Drawing.Point(171, 234);
            this.naamBox4.Name = "naamBox4";
            this.naamBox4.Size = new System.Drawing.Size(104, 22);
            this.naamBox4.TabIndex = 8;
            this.naamBox4.Visible = false;
            // 
            // naamLabel4
            // 
            this.naamLabel4.AutoSize = true;
            this.naamLabel4.BackColor = System.Drawing.Color.Red;
            this.naamLabel4.ForeColor = System.Drawing.Color.White;
            this.naamLabel4.Location = new System.Drawing.Point(61, 237);
            this.naamLabel4.Name = "naamLabel4";
            this.naamLabel4.Size = new System.Drawing.Size(104, 17);
            this.naamLabel4.TabIndex = 7;
            this.naamLabel4.Text = "Naam speler4: ";
            this.naamLabel4.Visible = false;
            // 
            // naamBox1
            // 
            this.naamBox1.Location = new System.Drawing.Point(171, 96);
            this.naamBox1.Name = "naamBox1";
            this.naamBox1.Size = new System.Drawing.Size(104, 22);
            this.naamBox1.TabIndex = 10;
            this.naamBox1.Visible = false;
            // 
            // naamLabel1
            // 
            this.naamLabel1.AutoSize = true;
            this.naamLabel1.BackColor = System.Drawing.Color.Red;
            this.naamLabel1.ForeColor = System.Drawing.Color.White;
            this.naamLabel1.Location = new System.Drawing.Point(61, 99);
            this.naamLabel1.Name = "naamLabel1";
            this.naamLabel1.Size = new System.Drawing.Size(104, 17);
            this.naamLabel1.TabIndex = 9;
            this.naamLabel1.Text = "Naam speler1: ";
            this.naamLabel1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(57, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 329);
            this.panel1.TabIndex = 11;
            // 
            // SpelersAanvragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 338);
            this.Controls.Add(this.naamBox1);
            this.Controls.Add(this.naamLabel1);
            this.Controls.Add(this.naamBox4);
            this.Controls.Add(this.naamLabel4);
            this.Controls.Add(this.naamBox3);
            this.Controls.Add(this.naamLabel3);
            this.Controls.Add(this.naamBox2);
            this.Controls.Add(this.naamLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.naarSpel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SpelersAanvragen";
            this.Text = "Spelers invoeren";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button naarSpel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label naamLabel2;
        private System.Windows.Forms.TextBox naamBox2;
        private System.Windows.Forms.TextBox naamBox3;
        private System.Windows.Forms.Label naamLabel3;
        private System.Windows.Forms.TextBox naamBox4;
        private System.Windows.Forms.Label naamLabel4;
        private System.Windows.Forms.TextBox naamBox1;
        private System.Windows.Forms.Label naamLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}