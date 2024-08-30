namespace print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            listhistorique = new ListView();
            colBENEFICIERE = new ColumnHeader();
            colMONTANT = new ColumnHeader();
            colDATE = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            text_montant = new TextBox();
            label3 = new Label();
            text_titulaire = new TextBox();
            label4 = new Label();
            label5 = new Label();
            text_beneficiere = new TextBox();
            label6 = new Label();
            text_adresse = new TextBox();
            label7 = new Label();
            date = new DateTimePicker();
            label8 = new Label();
            text_Ncompte = new TextBox();
            label9 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1063, 786);
            button1.Name = "button1";
            button1.Size = new Size(257, 98);
            button1.TabIndex = 0;
            button1.Text = "Imprimer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // listhistorique
            // 
            listhistorique.Columns.AddRange(new ColumnHeader[] { colBENEFICIERE, colMONTANT, colDATE });
            listhistorique.FullRowSelect = true;
            listhistorique.Location = new Point(12, 541);
            listhistorique.Name = "listhistorique";
            listhistorique.Size = new Size(987, 343);
            listhistorique.TabIndex = 1;
            listhistorique.UseCompatibleStateImageBehavior = false;
            listhistorique.View = View.Details;
            listhistorique.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colBENEFICIERE
            // 
            colBENEFICIERE.Text = "BENEFICIERE";
            colBENEFICIERE.Width = 370;
            // 
            // colMONTANT
            // 
            colMONTANT.Text = "MONTANT";
            colMONTANT.Width = 270;
            // 
            // colDATE
            // 
            colDATE.Text = "DATE";
            colDATE.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(516, 26);
            label1.Name = "label1";
            label1.Size = new Size(192, 46);
            label1.TabIndex = 2;
            label1.Text = "CHEQUE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(751, 100);
            label2.Name = "label2";
            label2.Size = new Size(149, 41);
            label2.TabIndex = 3;
            label2.Text = "Montant:";
            label2.Click += label2_Click;
            // 
            // text_montant
            // 
            text_montant.Location = new Point(938, 97);
            text_montant.Name = "text_montant";
            text_montant.Size = new Size(330, 48);
            text_montant.TabIndex = 4;
            text_montant.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 176);
            label3.Name = "label3";
            label3.Size = new Size(145, 41);
            label3.TabIndex = 3;
            label3.Text = "Titulaire:";
            label3.Click += label2_Click;
            // 
            // text_titulaire
            // 
            text_titulaire.Location = new Point(286, 176);
            text_titulaire.Multiline = true;
            text_titulaire.Name = "text_titulaire";
            text_titulaire.Size = new Size(752, 47);
            text_titulaire.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1274, 103);
            label4.Name = "label4";
            label4.Size = new Size(63, 41);
            label4.TabIndex = 5;
            label4.Text = "DH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 357);
            label5.Name = "label5";
            label5.Size = new Size(192, 41);
            label5.TabIndex = 3;
            label5.Text = "Bénéficiaire:";
            label5.Click += label2_Click;
            // 
            // text_beneficiere
            // 
            text_beneficiere.Location = new Point(286, 351);
            text_beneficiere.Multiline = true;
            text_beneficiere.Name = "text_beneficiere";
            text_beneficiere.Size = new Size(752, 47);
            text_beneficiere.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(78, 255);
            label6.Name = "label6";
            label6.Size = new Size(136, 41);
            label6.TabIndex = 3;
            label6.Text = "Adresse:";
            label6.Click += label2_Click;
            // 
            // text_adresse
            // 
            text_adresse.Location = new Point(286, 255);
            text_adresse.Multiline = true;
            text_adresse.Name = "text_adresse";
            text_adresse.Size = new Size(361, 47);
            text_adresse.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(683, 255);
            label7.Name = "label7";
            label7.Size = new Size(101, 41);
            label7.TabIndex = 3;
            label7.Text = "DATE:";
            label7.Click += label2_Click;
            // 
            // date
            // 
            date.Location = new Point(820, 249);
            date.Name = "date";
            date.Size = new Size(500, 48);
            date.TabIndex = 6;
            date.Value = new DateTime(2024, 8, 16, 0, 7, 7, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 112);
            label8.Name = "label8";
            label8.Size = new Size(226, 41);
            label8.TabIndex = 3;
            label8.Text = "N° De Compte:";
            label8.Click += label2_Click;
            // 
            // text_Ncompte
            // 
            text_Ncompte.Location = new Point(286, 109);
            text_Ncompte.Name = "text_Ncompte";
            text_Ncompte.Size = new Size(330, 48);
            text_Ncompte.TabIndex = 4;
            text_Ncompte.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 492);
            label9.Name = "label9";
            label9.Size = new Size(191, 41);
            label9.TabIndex = 7;
            label9.Text = "HISTORIQUE";
            // 
            // button2
            // 
            button2.Location = new Point(1005, 541);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 8;
            button2.Text = "vider";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 956);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(date);
            Controls.Add(label4);
            Controls.Add(text_beneficiere);
            Controls.Add(text_adresse);
            Controls.Add(text_titulaire);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(text_Ncompte);
            Controls.Add(text_montant);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listhistorique);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private ListView listhistorique;
        private Label label1;
        private Label label2;
        private TextBox text_montant;
        private Label label3;
        private TextBox text_titulaire;
        private Label label4;
        private Label label5;
        private TextBox text_beneficiere;
        private Label label6;
        private TextBox text_adresse;
        private Label label7;
        private DateTimePicker date;
        private Label label8;
        private TextBox text_Ncompte;
        private ColumnHeader colBENEFICIERE;
        private ColumnHeader colMONTANT;
        private ColumnHeader colDATE;
        private Label label9;
        private Button button2;
    }
}
