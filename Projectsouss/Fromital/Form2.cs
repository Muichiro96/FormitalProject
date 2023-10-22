
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Fromital
{

    public partial class Form2 : Form
    {
        private Form3 form3;

        private int id_cadre = 0;
        public Form2()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int annelot = 0;
            int jourannelot = 0;
            string etat = "En cours";

            var jourdanne = DateTime.Now.DayOfYear;
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                DataGridViewSelectedRowCollection b = dataGridView1.SelectedRows;
                id_cadre = (int)b[0].Cells[0].Value;
                label1.Text = "▬ Cadre  : " + b[0].Cells[0].Value.ToString() + "       \n" + "▬ Fromage   : " + b[0].Cells[1].Value.ToString() + "         \n" + "▬ Nombre_de_pieces  :" + b[0].Cells[2].Value.ToString() + "      \n" + "▬ Le_Lot    :" + b[0].Cells[3].Value.ToString() + "      \n";
                button2.Visible = true;
                string connectionString = "Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true";
                SqlConnection con;
                con = new SqlConnection(connectionString);


                con.Open();

                string selectquery = $"select etat from Etat where id_cadre ={id_cadre} and jour={jourdanne} and status='Fait' ";
                SqlCommand cmd = new SqlCommand(selectquery, con);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    etat = reader1.GetValue(0).ToString();


                }
                reader1.Close();

                con.Close();

                label1.Text += "▬ Etat :" + etat;

                form3 = new Form3(etat, id_cadre);





            }
            else if (selectedRowCount > 1)
            {
                MessageBox.Show("Veuillez selectionner une seule ligne", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Aucun ligne selectionnee", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true";
            SqlConnection con;
            con = new SqlConnection(connetionString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Cadre", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            form3.ShowDialog();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            id_cadre = 0;
            label1.Text = "";
            button2.Visible = false;
            dataGridView1.DataSource = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connetionString = "Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true";
            SqlConnection con;
            con = new SqlConnection(connetionString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Cadre", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
