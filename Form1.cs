using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace print
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = control as System.Windows.Forms.TextBox;

                    // Vérifie si le TextBox est vide
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Vérification basée sur le nom ou l'étiquette du TextBox (par exemple)
                    if (textBox.Name == "text_Ncompte"|| textBox.Name == "text_montant")
                    {
                        // Vérifie si la valeur est numérique
                        if (!int.TryParse(textBox.Text, out _))
                        {
                            MessageBox.Show("Le champ 'N° de Compte ou montant' doit contenir une valeur numérique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (textBox.Name == "text_titulaire"|| textBox.Name == "text_adresse" || textBox.Name == "text_beneficiere")
                    {
                        // Vérifie si la valeur est bien du texte (pas nécessaire en général mais inclus pour exemple)
                        if (!IsText(textBox.Text))
                        {
                            MessageBox.Show("Les champs 'titulaire,adresse,Beneficiaire' doit contenir uniquement du texte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    
                }
            }
                string[] tinfos = new string[] { text_beneficiere.Text, text_montant.Text, date.Value.ToShortDateString() };
                ListViewItem list = new ListViewItem(tinfos);
                listhistorique.Items.Add(list);

                //sauvegarde des historique dans une fichier
                StreamWriter saveList = new StreamWriter("historique.txt", false);
                foreach (ListViewItem maListe in listhistorique.Items)
                {
                    saveList.WriteLine(maListe.SubItems[0].Text + ";" + maListe.SubItems[1].Text + ";" + maListe.SubItems[2].Text);
                }
                saveList.Close();
                FormData formData = new FormData
                {
                    Data1 = text_Ncompte.Text,
                    Data2 = text_montant.Text,
                    Data3 = text_titulaire.Text,
                    Data4 = text_adresse.Text,
                    Data5 = date.Value.ToShortDateString(),
                    Data6 = text_beneficiere.Text

                };

                //
                Form2 f2 = new Form2(formData);
                f2.Show();
                f2.Refresh();
                Thread.Sleep(3000);

                // Capture l'image de Form2
                Graphics graphics = f2.CreateGraphics();
                Size size = f2.ClientSize;
                bitmap = new Bitmap(size.Width, size.Height, graphics);
                graphics = Graphics.FromImage(bitmap);

                Point point = f2.PointToScreen(new Point(0, 0));
                graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)

            {

                if (listhistorique.SelectedItems.Count > 0)
                {
                    // Récupérer l'élément sélectionné
                    ListViewItem selectedItem = listhistorique.SelectedItems[0];

                    // Assigner les valeurs des sous-éléments aux TextBox
                    text_beneficiere.Text = selectedItem.SubItems[0].Text;
                    text_montant.Text = selectedItem.SubItems[1].Text;
                    date.Text = selectedItem.SubItems[2].Text;
                }

            }

            private void button2_Click(object sender, EventArgs e)
            {
                File.WriteAllText("historique.txt", string.Empty);//vider le fichier
                listhistorique.Items.Clear();

            }

            private void Form1_Load(object sender, EventArgs e)
            {
                // Vérifie si le fichier "historique.txt" existe
                if (File.Exists("historique.txt"))
                {
                    try
                    {
                        using (StreamReader readList = new StreamReader("historique.txt"))
                        {
                            string ligne = string.Empty;
                            while ((ligne = readList.ReadLine()) != null)
                            {
                                string[] tabligne = ligne.Split(';');
                                ListViewItem itemList = new ListViewItem(tabligne);
                                listhistorique.Items.Add(itemList);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Gère les erreurs de lecture du fichier
                        MessageBox.Show("Une erreur s'est produite lors de la lecture du fichier : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private bool IsText(string input)
        {
            if (int.TryParse(input, out _))
            {
               
                return false;
            }
            return true;
        }
    }

       
    }
