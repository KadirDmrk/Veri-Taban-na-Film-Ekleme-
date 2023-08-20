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

namespace Veri_Tabanına_Resim_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P0AC89F\\SQLEXPRESS;Initial Catalog=Dbo_FilmArsiv;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Dosya açma penceresi 
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName; // Dosya yolunun  uzantısını text boxa yazdırdık
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Filmler (FilmAd,FilmTur,FilmPuan,FilmKategori,FilmResim) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtTur.Text);
            komut.Parameters.AddWithValue("@p3", float.Parse(TxtPuan.Text));
            komut.Parameters.AddWithValue("@p4", TxtKategori.Text);
            komut.Parameters.AddWithValue("@p5", TxtResim.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Eklenmıştir");
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbo_FilmArsivDataSet.Tbl_Filmler' table. You can move, or remove it, as needed.
            this.tbl_FilmlerTableAdapter.Fill(this.dbo_FilmArsivDataSet.Tbl_Filmler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex; // Herhangi bir hücreye tıkladıgım zaman bu hücrenın satır indexini seçilen isimli değişkene atadım .
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtPuan.Text=dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtKategori.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtResim.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            pictureBox1.ImageLocation= TxtResim.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString(); // Hücrelre tıkladıgımız zaman pictureboxda resim gosteriyor. Aynı mantık 
        }
    }
}
