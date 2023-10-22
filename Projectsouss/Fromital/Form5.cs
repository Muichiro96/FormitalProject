using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fromital
{
    public partial class Form5 : Form
    {
        private int ID;
        public Form5(string a)
        {
            ID = Int32.Parse(a);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connetionString = "Data Source=localhost;Initial Catalog=affinage;Trusted_Connection=true";
            SqlConnection con;
            con = new SqlConnection(connetionString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select id_cadre,etat,status,jour,date from Etat where id_cadre=" + ID +"and date< GETDATE()", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
