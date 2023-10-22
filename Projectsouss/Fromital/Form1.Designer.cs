namespace Fromital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            nbrpiece = new TextBox();
            label3 = new Label();
            label4 = new Label();
            fromage = new ComboBox();
            label5 = new Label();
            Lot = new TextBox();
            cadre = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(497, 372);
            button1.Name = "button1";
            button1.Size = new Size(117, 28);
            button1.TabIndex = 0;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.fromital;
            pictureBox1.Location = new Point(270, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 192);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 3;
            label1.Text = "Le type de fromage   :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 262);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre de pièce    :";
            label2.Click += label2_Click;
            // 
            // nbrpiece
            // 
            nbrpiece.Location = new Point(173, 259);
            nbrpiece.Name = "nbrpiece";
            nbrpiece.PlaceholderText = "20";
            nbrpiece.Size = new Size(193, 23);
            nbrpiece.TabIndex = 5;
            nbrpiece.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 9);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Le jour :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 283);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // fromage
            // 
            fromage.AccessibleDescription = "";
            fromage.AccessibleName = "";
            fromage.Cursor = Cursors.Hand;
            fromage.FormattingEnabled = true;
            fromage.Items.AddRange(new object[] { "EDAM", "FONTAL PYRINEES GOUDA", "Saint Paulin", "Parmesan" });
            fromage.Location = new Point(527, 189);
            fromage.Name = "fromage";
            fromage.Size = new Size(184, 23);
            fromage.TabIndex = 9;
            fromage.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 262);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 10;
            label5.Text = "Le Lot                          :";
            label5.Click += label5_Click;
            // 
            // Lot
            // 
            Lot.Location = new Point(527, 259);
            Lot.Name = "Lot";
            Lot.PlaceholderText = "23/001";
            Lot.Size = new Size(184, 23);
            Lot.TabIndex = 11;
            // 
            // cadre
            // 
            cadre.Location = new Point(173, 189);
            cadre.Name = "cadre";
            cadre.PlaceholderText = "1450";
            cadre.Size = new Size(193, 23);
            cadre.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 192);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 13;
            label6.Text = "№ Cadre                   :";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(60, 371);
            button2.Name = "button2";
            button2.Size = new Size(147, 28);
            button2.TabIndex = 14;
            button2.Text = "Voir Cadres >>";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(655, 373);
            button3.Name = "button3";
            button3.Size = new Size(116, 26);
            button3.TabIndex = 15;
            button3.Text = "Pointer état ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(cadre);
            Controls.Add(Lot);
            Controls.Add(label5);
            Controls.Add(fromage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nbrpiece);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gestion de cave d'affinage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox nbrpiece;
        private Label label3;
        private Label label4;
        private ComboBox fromage;
        private Label label5;
        private TextBox Lot;
        private TextBox cadre;
        private Label label6;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}