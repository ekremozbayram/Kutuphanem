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
    public partial class AramaForm : Form
    {
        Baglanti baglanti = new Baglanti();
        SqlConnection con;

        public AramaForm()
        {
            InitializeComponent();
        }

        private void KEFormB_Click(object sender, EventArgs e)
        {
            EklemeForm eklef = new EklemeForm();
            this.Hide();
            eklef.Show();
        }

        private void AramaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void AramaForm_Load(object sender, EventArgs e)
        {
           
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut = "Select KitapTBL.Barkod, KitapTBL.Ad, KitapTBL.Yazar, KitapTBL.BasimYili, YayineviTBL.Ad from YayineviTBL inner join KitapTBL on (YayineviTBL.Id=KitapTBL.Yayinevi)";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            SqlCommandBuilder cc = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AramaDG.DataSource = dt;
            con.Close(); AramaDG.Columns[1].HeaderText = "Kitap Adı";
            con.Close(); AramaDG.Columns[3].HeaderText = "Basım Tarihi";
            con.Close(); AramaDG.Columns[4].HeaderText = "Yayınevi";
        }
        private void AramaTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AramaTb.Text == "")
            {
                con = new SqlConnection(baglanti.bagla());
                con.Open();
                string komut = "Select KitapTBL.Barkod, KitapTBL.Ad, KitapTBL.Yazar, KitapTBL.BasimYili, YayineviTBL.Ad from YayineviTBL inner join KitapTBL on (YayineviTBL.Id=KitapTBL.Yayinevi)";
                SqlDataAdapter da = new SqlDataAdapter(komut, con);
                SqlCommandBuilder cc = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AramaDG.DataSource = dt;
                con.Close();
            }
            else
            {
                con = new SqlConnection(baglanti.bagla());
                con.Open();
                string komut = "Select KitapTBL.Barkod, KitapTBL.Ad, KitapTBL.Yazar, KitapTBL.BasimYili, YayineviTBL.Ad from YayineviTBL inner join KitapTBL on (YayineviTBL.Id=KitapTBL.Yayinevi) where KitapTBL.Ad like '%" + AramaTb.Text +"%'";
                SqlDataAdapter da = new SqlDataAdapter(komut, con);
                SqlCommandBuilder cc = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AramaDG.DataSource = dt;
                con.Close();
            }
        }
    }
}
