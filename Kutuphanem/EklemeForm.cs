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

namespace Kutuphanem
{
    public partial class EklemeForm : Form
    {
        Baglanti baglanti = new Baglanti();
        SqlConnection con;
        public EklemeForm()
        {
            InitializeComponent();
        }
        private void KAFormBu_Click_1(object sender, EventArgs e)
        {
            AramaForm aramaF = new AramaForm();
            this.Hide();
            aramaF.Show();
        }

        private void EklemeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void EklemeForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            DataTable dt = new DataTable();
            string komut = "Select * From YayineviTBL";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            da.Fill(dt);
            YayinCb.ValueMember = "Id";
            YayinCb.DisplayMember = "Ad";
            YayinCb.DataSource = dt;
            con.Close();
        }

        private void EkleB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komutText = "INSERT INTO KitapTBL VALUES ('"+BarkodTb.Text+"','"+KAdiTb.Text+"','"+YazarTb.Text+"','"+BasimYTb.Text+"','"+YayinCb.SelectedValue+"')";
            SqlCommand komut = new SqlCommand(komutText, con);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Close();
            con.Close();
        }
    }
}
