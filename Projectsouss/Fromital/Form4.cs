using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Fromital
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            cn = new SqlConnection("Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true");
            cn.Open();
            cmd = new SqlCommand("select id_cadre from Cadre", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
            cn.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Veuillez remplir les elements ci dessus !! :>");
            }
            else
            {
                string status;
                int a;
                string etat;
                string id;
                etat = comboBox2.Text;
                id = comboBox1.Text;
                int d = DateTime.Now.DayOfYear;
                int.TryParse(id, out a);
                if (checkBox1.Checked)
                {
                    status = "Fait";
                }
                else { status = "Pas Fait"; }
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true");
                SqlCommand command = new SqlCommand(null, con);


                command.CommandText =
                    "IF EXISTS (SELECT * FROM Etat WHERE jour=" + d + "and id_cadre=" + id + ") \r\nBEGIN\r\n  UPDATE Etat\r\nSET etat=@etat,status=@status WHERE jour=" + d + "and id_cadre=" + id + " \r\nEND\r\nELSE\r\nBEGIN\r\nInsert into Etat(etat,status,id_cadre,jour) VALUES (@etat,@status,@id,@jour) END";
                SqlParameter state = new SqlParameter("@etat", SqlDbType.VarChar, 255);
                SqlParameter av = new SqlParameter("@status", SqlDbType.VarChar, 50);
                SqlParameter idcadre = new SqlParameter("@id", SqlDbType.Int);
                SqlParameter journ = new SqlParameter("@jour", SqlDbType.Int);


                state.Value = etat;
                av.Value = status;
                idcadre.Value = id;
                journ.Value = d;
                command.Parameters.Add(state);
                command.Parameters.Add(av);
                command.Parameters.Add(idcadre);
                command.Parameters.Add(journ);
                try
                {
                    con.Open();
                    command.Prepare();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Success", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Etat déja pointée pour ajourd'hui", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Veuillez séléctioner un cadre ;Dans le champ ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int b;
                string ak = comboBox1.Text;


                Form5 form5 = new Form5(ak);
                form5.ShowDialog();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connetionString = "Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true";
            SqlConnection con;
            con = new SqlConnection(connetionString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select id_cadre,etat,status,date from Etat", con);
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
