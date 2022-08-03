using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Text.RegularExpressions;
//using System.Data.OleDb;
namespace Ziyaretci_kaydi
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Server=.; Initial Catalog=ZiyaretKayit; Integrated Security=True");
        SqlCommand komut;
        int eklenen = 1;
        ErrorProvider provider = new ErrorProvider();
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            otoid();
        }
        private void otoid()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            dataGridView1.AllowUserToAddRows = false;
        }
        public static bool TelefonFormatKontrol(string tel)
        {
            string RegexDesen = @"^(0(\d{1})(\d{9}))$";
            Match Eslesme = Regex.Match(tel, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success;
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            //int sayac = 0;
            //baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ziyaretci(adsoyad,unvan,adres,telefon,ziyaretsebebi,ziyarettarihi,girissaati,cikissaati)values(@adsoyad,@unvan,@adres,@tel,@sebeb,@tarih,@giris,@cikis)", baglanti);
            string[] veri = maskedTextBox2.Text.Split(':');
            int saat = 0, dakika = 0, saniye = 0;
            if (veri[0] != "" && veri[1] != "" && veri[2] != "")
            {
                saat = Convert.ToInt32(veri[0]);
                dakika = Convert.ToInt32(veri[1]);
                saniye = Convert.ToInt32(veri[2]);
            }
            if (saat <= 24 && dakika <= 60 && saniye <= 60)
            {
                //MessageBox.Show("ok");
                verilerigoster("select * from ziyaretci");
            }
            else
            {
                MessageBox.Show("saat verisi hatalı");
                eklenen = 0;
            }
            bool TelefonDogruMu = TelefonFormatKontrol(tel.Text);
            if (TelefonDogruMu == true)
            {
                verilerigoster("select * from ziyaretci");               
            }
            else
            {
                MessageBox.Show("Telefon numarası hatalıdır. Lütfen kontrol ediniz.");
                eklenen = 0;
            }
            if (eklenen != 0)
            {
                komut.Parameters.AddWithValue("@adsoyad", adsoyad.Text);
                komut.Parameters.AddWithValue("@unvan", unvan.Text);
                komut.Parameters.AddWithValue("@adres", adres.Text);
                komut.Parameters.AddWithValue("@tel", tel.Text);
                komut.Parameters.AddWithValue("@sebeb", sebeb.Text);
                komut.Parameters.AddWithValue("@tarih", tarih.Text);
                komut.Parameters.AddWithValue("@giris", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@cikis", maskedTextBox2.Text);
                baglanti.Open();
                eklenen = komut.ExecuteNonQuery();
                verilerigoster("select * from ziyaretci");
                baglanti.Close();
                otoid();
                adsoyad.Clear();
                unvan.Clear();
                adres.Clear();
                tel.Clear();
                sebeb.Text = "";
                tarih.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                //baglanti.Close();
            }
            else
            {
                MessageBox.Show("kayıt işlemi başarısız");
            }
           
            timer1.Start();
            maskedTextBox1.Enabled = true;         
        }
        private void adsoyad_Validating(object sender, CancelEventArgs e)
        {
            if (adsoyad.Text.Trim() == "")
            {
                provider.SetError(adsoyad, "AdSoyad değerini girmelisiniz");
                eklenen = 0;
            }
            else
            {
                provider.SetError(adsoyad, "");
                eklenen = 1;
            }
        }
        private void unvan_Validated(object sender, EventArgs e)
        {
            if (unvan.Text.Trim() == "")
            {
                provider.SetError(unvan, "Ünvan değerini girmelisiniz");
                eklenen = 0;
            }
            else
            {
                provider.SetError(unvan, "");
                eklenen = 1;
            }
        }
        private void adres_Validated(object sender, EventArgs e)
        {
            if (adres.Text.Trim() == "")
            {
                provider.SetError(adres, "Adres değerini girmelisiniz");
                eklenen = 0;
            }
            else
            {
                provider.SetError(adres, "");
                eklenen = 1;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * from ziyaretci");
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from ziyaretci where adsoyad like '%" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            otoid();
            int bilgi;
            bilgi = dataGridView1.RowCount;
            MessageBox.Show("Adet kayıt bulundu", bilgi.ToString());
            textBox1.Text = "";
            verilerigoster("select * from ziyaretci");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();
                //Aplication.Exit();
            }
            else if (x == DialogResult.No)
            {
            }
        }
        void KayıtSil(String adsoyad)
        {
            string sql = "DELETE FROM ziyaretci WHERE adsoyad=@adsoyad";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@adsoyad", adsoyad);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                string adsoyad = Convert.ToString(drow.Cells[1].Value);
                KayıtSil(adsoyad);
                verilerigoster("select * from ziyaretci");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook RES = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)RES.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToLongDateString();
            maskedTextBox1.Text = DateTime.Now.ToLongTimeString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            SqlCommand komut = new SqlCommand("update ziyaretci(adsoyad,unvan,adres,telefon,ziyaretsebebi,ziyarettarihi,girissaati,cikissaati)values(@adsoyad,@unvan,@adres,@tel,@sebeb,@tarih,@giris,@cikis)", baglanti);
            adsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            unvan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            adres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sebeb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            timer1.Stop();
            maskedTextBox1.Enabled = false;
            verilerigoster("select * from ziyaretci");
        }
        private void dgv_cellenter(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void tel_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void tel_TextChanged(object sender, EventArgs e)
        {
        }
        private void adsoyad_TextChanged(object sender, EventArgs e)
        {

        }
        private void adsoyad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void unvan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void sebeb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}