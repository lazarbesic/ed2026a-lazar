using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ed2026a_lazar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-VTJ1B2M\\SQLEXPRESS;Initial Catalog=ed2026a;Integrated Security=True";
            DataTable podaci = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from osoba", cs);
            adapter.Fill(podaci);
            txtId.Text = podaci.Rows[0]["id"].ToString();
            txtIme.Text = podaci.Rows[0]["ime"].ToString();
            txtPrezime.Text = podaci.Rows[0]["prezime"].ToString();
            txtJmbg.Text = podaci.Rows[0]["jmbg"].ToString();
            txtEmail.Text = podaci.Rows[0]["email"].ToString();
            txtLozinka.Text = podaci.Rows[0]["lozinka"].ToString();
            txtUloga.Text = podaci.Rows[0]["uloga"].ToString();
        }
    }
}
