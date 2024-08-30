namespace print
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1 = new GroupBox();
            Aff_montant_lettre = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            Aff_beneficiere = new Label();
            label6 = new Label();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            Aff_Ncompte = new Label();
            Aff_montant = new Label();
            Aff_adresse = new Label();
            affi_date = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog2";
            printPreviewDialog1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Aff_montant_lettre);
            groupBox1.Location = new Point(141, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1232, 239);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "PAYER CONTRE SE CHÈQUE/ادفعوا مقابل هذا الشيك";
            // 
            // Aff_montant_lettre
            // 
            Aff_montant_lettre.AutoSize = true;
            Aff_montant_lettre.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Aff_montant_lettre.Location = new Point(40, 57);
            Aff_montant_lettre.MaximumSize = new Size(1200, 0);
            Aff_montant_lettre.Name = "Aff_montant_lettre";
            Aff_montant_lettre.Size = new Size(132, 46);
            Aff_montant_lettre.TabIndex = 0;
            Aff_montant_lettre.Text = "label3\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1504, 94);
            label4.Name = "label4";
            label4.Size = new Size(81, 41);
            label4.TabIndex = 8;
            label4.Text = "درهم";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Aff_beneficiere);
            groupBox2.Location = new Point(141, 417);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1232, 121);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "A L'ORDRE DE /لأمر";
            // 
            // Aff_beneficiere
            // 
            Aff_beneficiere.AutoSize = true;
            Aff_beneficiere.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Aff_beneficiere.Location = new Point(141, 66);
            Aff_beneficiere.Name = "Aff_beneficiere";
            Aff_beneficiere.Size = new Size(132, 46);
            Aff_beneficiere.TabIndex = 0;
            Aff_beneficiere.Text = "label4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(665, 551);
            label6.Name = "label6";
            label6.Size = new Size(55, 41);
            label6.TabIndex = 9;
            label6.Text = "A :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1140, 551);
            label1.Name = "label1";
            label1.Size = new Size(113, 41);
            label1.TabIndex = 9;
            label1.Text = " في LE:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(60, 94);
            label8.Name = "label8";
            label8.Size = new Size(226, 41);
            label8.TabIndex = 11;
            label8.Text = "N° De Compte:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(731, 18);
            label2.Name = "label2";
            label2.Size = new Size(192, 46);
            label2.TabIndex = 13;
            label2.Text = "CHÈQUE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(1298, 786);
            label3.Name = "label3";
            label3.Size = new Size(336, 45);
            label3.TabIndex = 13;
            label3.Text = "SIGNATURE/التوقيع";
            // 
            // Aff_Ncompte
            // 
            Aff_Ncompte.AutoSize = true;
            Aff_Ncompte.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Aff_Ncompte.Location = new Point(306, 94);
            Aff_Ncompte.Name = "Aff_Ncompte";
            Aff_Ncompte.Size = new Size(132, 46);
            Aff_Ncompte.TabIndex = 15;
            Aff_Ncompte.Text = "label1";
            Aff_Ncompte.Click += Aff_Ncompte_Click;
            // 
            // Aff_montant
            // 
            Aff_montant.AutoSize = true;
            Aff_montant.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Aff_montant.Location = new Point(1259, 94);
            Aff_montant.Name = "Aff_montant";
            Aff_montant.Size = new Size(132, 46);
            Aff_montant.TabIndex = 16;
            Aff_montant.Text = "label2";
            // 
            // Aff_adresse
            // 
            Aff_adresse.AutoSize = true;
            Aff_adresse.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Aff_adresse.Location = new Point(726, 551);
            Aff_adresse.Name = "Aff_adresse";
            Aff_adresse.Size = new Size(132, 46);
            Aff_adresse.TabIndex = 17;
            Aff_adresse.Text = "label5";
            // 
            // affi_date
            // 
            affi_date.AutoSize = true;
            affi_date.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            affi_date.Location = new Point(1259, 551);
            affi_date.Name = "affi_date";
            affi_date.Size = new Size(132, 46);
            affi_date.TabIndex = 18;
            affi_date.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1082, 94);
            label5.Name = "label5";
            label5.Size = new Size(63, 41);
            label5.TabIndex = 19;
            label5.Text = "DH";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1740, 840);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1740, 840);
            Controls.Add(label5);
            Controls.Add(affi_date);
            Controls.Add(Aff_adresse);
            Controls.Add(Aff_montant);
            Controls.Add(Aff_Ncompte);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CHÈQUE";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private GroupBox groupBox1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label4;
        private GroupBox groupBox2;
        private Label label6;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label Aff_montant_lettre;
        private Label Aff_beneficiere;
        private Label Aff_Ncompte;
        private Label Aff_montant;
        private Label Aff_adresse;
        private Label affi_date;
        private Label label5;
        private PictureBox pictureBox1;
    }
}