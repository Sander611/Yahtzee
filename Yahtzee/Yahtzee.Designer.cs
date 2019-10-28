namespace Yahtzee
{
    partial class Yahtzee
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
            this.worpenListBox = new System.Windows.Forms.ListView();
            this.linksBovenBox = new System.Windows.Forms.PictureBox();
            this.linksMiddenBox = new System.Windows.Forms.PictureBox();
            this.rechtsBovenBox = new System.Windows.Forms.PictureBox();
            this.rechtsMiddenBox = new System.Windows.Forms.PictureBox();
            this.linksOnderBox = new System.Windows.Forms.PictureBox();
            this.dobbelButton = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.worpenListBox2 = new System.Windows.Forms.ListView();
            this.volgendeBeurt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.spelerNaamVeld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.linksBovenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksMiddenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechtsBovenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechtsMiddenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksOnderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // worpenListBox
            // 
            this.worpenListBox.HideSelection = false;
            this.worpenListBox.Location = new System.Drawing.Point(13, 29);
            this.worpenListBox.Name = "worpenListBox";
            this.worpenListBox.Size = new System.Drawing.Size(450, 180);
            this.worpenListBox.TabIndex = 0;
            this.worpenListBox.UseCompatibleStateImageBehavior = false;
            this.worpenListBox.Click += new System.EventHandler(this.ListBox_Click);
            // 
            // linksBovenBox
            // 
            this.linksBovenBox.Location = new System.Drawing.Point(552, 29);
            this.linksBovenBox.Name = "linksBovenBox";
            this.linksBovenBox.Size = new System.Drawing.Size(105, 97);
            this.linksBovenBox.TabIndex = 1;
            this.linksBovenBox.TabStop = false;
            this.linksBovenBox.Click += new System.EventHandler(this.dobbel_Click);
            // 
            // linksMiddenBox
            // 
            this.linksMiddenBox.Location = new System.Drawing.Point(552, 173);
            this.linksMiddenBox.Name = "linksMiddenBox";
            this.linksMiddenBox.Size = new System.Drawing.Size(105, 97);
            this.linksMiddenBox.TabIndex = 2;
            this.linksMiddenBox.TabStop = false;
            this.linksMiddenBox.Click += new System.EventHandler(this.dobbel_Click);
            // 
            // rechtsBovenBox
            // 
            this.rechtsBovenBox.Location = new System.Drawing.Point(717, 29);
            this.rechtsBovenBox.Name = "rechtsBovenBox";
            this.rechtsBovenBox.Size = new System.Drawing.Size(105, 97);
            this.rechtsBovenBox.TabIndex = 3;
            this.rechtsBovenBox.TabStop = false;
            this.rechtsBovenBox.Click += new System.EventHandler(this.dobbel_Click);
            // 
            // rechtsMiddenBox
            // 
            this.rechtsMiddenBox.Location = new System.Drawing.Point(717, 173);
            this.rechtsMiddenBox.Name = "rechtsMiddenBox";
            this.rechtsMiddenBox.Size = new System.Drawing.Size(105, 97);
            this.rechtsMiddenBox.TabIndex = 4;
            this.rechtsMiddenBox.TabStop = false;
            this.rechtsMiddenBox.Click += new System.EventHandler(this.dobbel_Click);
            // 
            // linksOnderBox
            // 
            this.linksOnderBox.Location = new System.Drawing.Point(552, 312);
            this.linksOnderBox.Name = "linksOnderBox";
            this.linksOnderBox.Size = new System.Drawing.Size(105, 97);
            this.linksOnderBox.TabIndex = 5;
            this.linksOnderBox.TabStop = false;
            this.linksOnderBox.Click += new System.EventHandler(this.dobbel_Click);
            // 
            // dobbelButton
            // 
            this.dobbelButton.Location = new System.Drawing.Point(552, 430);
            this.dobbelButton.Name = "dobbelButton";
            this.dobbelButton.Size = new System.Drawing.Size(195, 23);
            this.dobbelButton.TabIndex = 7;
            this.dobbelButton.Text = "Dobbelen";
            this.dobbelButton.UseVisualStyleBackColor = true;
            this.dobbelButton.Click += new System.EventHandler(this.dobbelButton_Click);
            // 
            // endTurnButton
            // 
            this.endTurnButton.Enabled = false;
            this.endTurnButton.Location = new System.Drawing.Point(552, 464);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(195, 23);
            this.endTurnButton.TabIndex = 8;
            this.endTurnButton.Text = "End turn";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Deel 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Deel 1";
            // 
            // worpenListBox2
            // 
            this.worpenListBox2.HideSelection = false;
            this.worpenListBox2.Location = new System.Drawing.Point(13, 229);
            this.worpenListBox2.Name = "worpenListBox2";
            this.worpenListBox2.Size = new System.Drawing.Size(450, 190);
            this.worpenListBox2.TabIndex = 12;
            this.worpenListBox2.UseCompatibleStateImageBehavior = false;
            this.worpenListBox2.Click += new System.EventHandler(this.ListBox_Click);
            // 
            // volgendeBeurt
            // 
            this.volgendeBeurt.Enabled = false;
            this.volgendeBeurt.Location = new System.Drawing.Point(771, 430);
            this.volgendeBeurt.Name = "volgendeBeurt";
            this.volgendeBeurt.Size = new System.Drawing.Size(85, 23);
            this.volgendeBeurt.TabIndex = 13;
            this.volgendeBeurt.Text = "Next";
            this.volgendeBeurt.UseVisualStyleBackColor = true;
            this.volgendeBeurt.Click += new System.EventHandler(this.volgendeBeurt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(717, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Beurt aan:";
            // 
            // spelerNaamVeld
            // 
            this.spelerNaamVeld.AutoSize = true;
            this.spelerNaamVeld.Location = new System.Drawing.Point(720, 333);
            this.spelerNaamVeld.Name = "spelerNaamVeld";
            this.spelerNaamVeld.Size = new System.Drawing.Size(77, 17);
            this.spelerNaamVeld.TabIndex = 21;
            this.spelerNaamVeld.Text = "[naamHier]";
            // 
            // Yahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 510);
            this.Controls.Add(this.spelerNaamVeld);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.volgendeBeurt);
            this.Controls.Add(this.worpenListBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.dobbelButton);
            this.Controls.Add(this.linksOnderBox);
            this.Controls.Add(this.rechtsMiddenBox);
            this.Controls.Add(this.rechtsBovenBox);
            this.Controls.Add(this.linksMiddenBox);
            this.Controls.Add(this.linksBovenBox);
            this.Controls.Add(this.worpenListBox);
            this.Name = "Yahtzee";
            this.Text = "Yahtzee";
            ((System.ComponentModel.ISupportInitialize)(this.linksBovenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksMiddenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechtsBovenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechtsMiddenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksOnderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView worpenListBox;
        private System.Windows.Forms.PictureBox linksBovenBox;
        private System.Windows.Forms.PictureBox linksMiddenBox;
        private System.Windows.Forms.PictureBox rechtsBovenBox;
        private System.Windows.Forms.PictureBox rechtsMiddenBox;
        private System.Windows.Forms.PictureBox linksOnderBox;
        private System.Windows.Forms.Button dobbelButton;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView worpenListBox2;
        private System.Windows.Forms.Button volgendeBeurt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label spelerNaamVeld;
    }
}

