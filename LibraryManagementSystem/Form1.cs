using LibraryManagementSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"data source = ZAFERPC\SQLEXPRESS;initial catalog = LibraryManagement;user id = sa;password = 1046");
        public Form1()
        {
            InitializeComponent();
        }
        public void temizlik()
        {
            foreach (Control cont in Controls)
            {
                if (cont is TextBox)
                {
                    ((TextBox)cont).Clear();
                }
            }
            foreach (Control control in Controls)
            {
                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int sonuc = kitapekle();
            if (sonuc == 1) 
            {
                MessageBox.Show("Kayıt eklendi. Görmek için 'LİSTELE' butonunu kullanınız.","BAŞARILI KAYIT",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt eklenirken hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temizlik();
        }

        public int kitapekle()
        {
            if (string.IsNullOrWhiteSpace(txt_isim.Text) || string.IsNullOrWhiteSpace(txt_yazar.Text) || string.IsNullOrWhiteSpace(txt_kitapnumara.Text))
            {
                MessageBox.Show("Lütfen (ID hariç) tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; 
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Books (Title, Author, ISBN, Available) VALUES (@isim, @yazar, @kitapno, @durum)", con);
                cmd.Parameters.AddWithValue("@isim", txt_isim.Text);
                cmd.Parameters.AddWithValue("@yazar", txt_yazar.Text);
                cmd.Parameters.AddWithValue("@kitapno", txt_kitapnumara.Text);
                cmd.Parameters.AddWithValue("@durum", durum());
                int donendeger = cmd.ExecuteNonQuery();
                con.Close();

                if (donendeger == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<kitaplar> listele()
        {
            List<kitaplar> ktp = new List<kitaplar>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Books", con);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                kitaplar ktp2 = new kitaplar();
                ktp2.BookId = int.Parse(reader["BookId"].ToString());
                ktp2.Title = reader["Title"].ToString();
                ktp2.Author = reader["Author"].ToString();
                ktp2.ISBN = reader["ISBN"].ToString();
                ktp2.Available = int.Parse(reader["Available"].ToString());
                ktp.Add(ktp2);
            }
            con.Close();
            return ktp;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            List<kitaplar> ktphn = listele();
            dataGridView1.DataSource = ktphn;
            temizlik();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public int durum()
        {
            if(radiobtn_1.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int guncelle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Books set Available = @Available where BookId = @id ", con);
            cmd.Parameters.AddWithValue("@Available",durum());
            cmd.Parameters.AddWithValue("@id",int.Parse(txt_id.Text));
            int gelen = cmd.ExecuteNonQuery();
            con.Close();
            if(gelen == 1)
            {
                return 1;

            }
            else
            {
                return 0;
            }
        }
        private void btn_durumgüncelle_Click(object sender, EventArgs e)
        {
            int sonuc = guncelle();

            if(sonuc == 1)
            {
                MessageBox.Show("Kitap durumu güncellendi.Görmek için 'LİSTELE' butonunu kullanınız.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Kitap durumu güncellenirken bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temizlik();
        }

        public int sil()
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Lütfen ID bilgisi giriniz..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Books where BookId = @id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
                int donendeger = cmd.ExecuteNonQuery();
                con.Close();
                if (donendeger == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int sonuc = sil();
            if(sonuc == 1)
            {
                MessageBox.Show("Kitap kaydı silinmiştir.Görmek için 'LİSTELE' butonunu kullanınız.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kitap kaydı silinirken hata oluştu.","HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temizlik();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string BookId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_id.Text = BookId;
            string Title = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_isim.Text = Title;
            string Author = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_yazar.Text = Author;
            string ISBN = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kitapnumara.Text = ISBN;
        }
    }
}
