using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace print
{
    public partial class Form2 : Form
    {
        public Form2(FormData formdata)
        {

            InitializeComponent();
            Aff_Ncompte.Text = formdata.Data1;
            Aff_montant.Text = formdata.Data2;
            Aff_adresse.Text = formdata.Data4;
            affi_date.Text = formdata.Data5;
            Aff_beneficiere.Text = formdata.Data6;
            int valeur;
            if (int.TryParse(formdata.Data2, out valeur))
            {
                Aff_montant_lettre.Text = Conversion.NumberToWords(valeur) + " Dirhams" ;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Aff_Ncompte_Click(object sender, EventArgs e)
        {

        }
    }
}
