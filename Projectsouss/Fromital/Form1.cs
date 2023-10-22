using System;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Linq.Expressions;

namespace Fromital
{



    public partial class Form1 : Form
    {
        public string message = " ";
        public Form1()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            timer1.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {




        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }




        private void button1_Click_1(object sender, EventArgs e)
        {

            if ((string.IsNullOrWhiteSpace(fromage.Text) || string.IsNullOrWhiteSpace(cadre.Text) || string.IsNullOrWhiteSpace(" " + cadre.Text) || string.IsNullOrWhiteSpace(" " + Lot.Text) || string.IsNullOrWhiteSpace(" " + nbrpiece.Text)))
            {
                try
                {
                    MessageBox.Show("Veuillez remplir les elements ci dessus !! :>");
                }
                catch (Exception ouss)
                {
                    MessageBox.Show(ouss.Message, "Erreur");
                }
            }
            else
            {
                string numcadre = cadre.Text;
                string connetionString;
                SqlConnection cnn;
                int a;
                int.TryParse(numcadre, out a);
                connetionString = "Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true";
                cnn = new SqlConnection(@connetionString);
                string nbrp = nbrpiece.Text;
                int.TryParse(nbrp, out a);
                string[] Lot4 = Lot.Text.Split("/");


                string annedebutentier = Lot4[0];
                int.TryParse(annedebutentier, out a);
                string jourl = Lot4[1];
                int.TryParse(jourl, out a);
                string query = "INSERT INTO Cadre (id_cadre,Type_fromage,nombre_piece,Le_lot) VALUES(@cadre,@fromage,@nombre,@lot)";
                SqlCommand command = new SqlCommand(query, cnn);

                command.Parameters.AddWithValue("@cadre", numcadre);
                command.Parameters.AddWithValue("@fromage", " " + fromage.Text);
                command.Parameters.AddWithValue("@nombre", nbrp);
                command.Parameters.AddWithValue("@lot", "" + Lot.Text);
                SqlCommand command2 = new SqlCommand(null, cnn);


                command2.CommandText =
                    "Insert into Date(Annee,jour_anne,id_cadre) VALUES (@annee,@jour,@id)";
                SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                SqlParameter jourParam = new SqlParameter("@jour", SqlDbType.Int);
                SqlParameter anneParam = new SqlParameter("@annee", SqlDbType.Int);

                idParam.Value = numcadre;
                jourParam.Value = jourl;
                anneParam.Value = annedebutentier;
                command2.Parameters.Add(idParam);
                command2.Parameters.Add(jourParam);
                command2.Parameters.Add(anneParam);


                // Call Prepare after setting the Commandtext and Parameters.

                try
                {
                    cnn.Open();
                    command.ExecuteNonQuery();
                    command2.Prepare();
                    command2.ExecuteNonQuery();





                    string message = "Ajouté avec succès :";
                    string title = "Succès";
                    DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    cnn.Close();

                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // <-- but this will
                    {
                        MessageBox.Show("Erreur  !  l'element deja ajoutee !? Voir les cadres  :(", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Erreur  ! Veuillez ressayer ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }



        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();


            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;

            this.label3.Text = "Le jour : " + datetime.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}