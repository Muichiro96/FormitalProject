using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fromital
{

    public partial class Form3 : Form
    {
        public string Etat { get; set; } = "";
        public int ID { get; set; }
        private void etat(string stat)
        {
            switch (stat)
            {
                case "Application antifongique 1":
                case "Application antifongique 2":
                case "Application antifongique 3":
                    pictureBox1.Image = Properties.Resources.application;
                    label3.Text = "" + Etat;
                    break;
                case "Retournement 1":
                case "Retournement 2":
                case "Retournement 3":
                    pictureBox1.Image = Properties.Resources.Retournement;
                    label3.Text = "" + Etat;
                    label4.Text = "Régulièrement, l’affineur retourne les fromages afin de les développer\n de façon homogène. Le fait de retourner régulièrement le produit afin\n d’avoir un affinage homogène sur tout le fromage.";
                    break;
                default:
                    label3.Text = "" + Etat;
                    break;
            }
        }
        public Form3(string state,int id)
        {
            this.Etat = state;
            this.ID = id;
            this.MaximizeBox = false;
            InitializeComponent();
            label3.Text = "" + state;
            etat(state);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true";
            SqlConnection con;
            con = new SqlConnection(connectionString);


            con.Open();

            string selectquery = $"select etat from Etat where id_cadre ={ID} and jour={DateTime.Now.DayOfYear} and status='Fait' ";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                Etat = reader1.GetValue(0).ToString();


            }
            etat(Etat);

        }
    }
}
