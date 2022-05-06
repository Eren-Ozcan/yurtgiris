using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace yurtdenemeicin
{
    public partial class OgrKayıt : Form
    {
        public OgrKayıt()
        {
            InitializeComponent();
            Combobox1sql();
            Combobox2sql();

        }

        //bölümleri listeleme komutları

        void Combobox1sql()
        {
            string bags = "datasource=localhost;port=3306;username=root;password=3131";
            string Sorgu = "SELECT * FROM yurtoto.bölümler ORDER BY bölüm_ad ASC;";
            MySqlConnection bagBase = new MySqlConnection(bags);
            MySqlCommand cmdBase = new MySqlCommand(Sorgu, bagBase);
            MySqlDataReader myReader;

            try
            {
                bagBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    string bolumAd = myReader.GetString("bölüm_ad");
                    comboBox1.Items.Add(bolumAd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //odaları listeleme komutları
        void Combobox2sql()
        {
            string bags = "datasource=localhost;port=3306;username=root;password=3131";
            string Sorgu = "SELECT * FROM yurtoto.odalar WHERE oda_kişisayı != oda_aktif;";
            //oda_no
            MySqlConnection bagBase = new MySqlConnection(bags);
            MySqlCommand cmdBase = new MySqlCommand(Sorgu, bagBase);

            MySqlDataReader myReader;

            try
            {
                bagBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    string odaNo = myReader.GetString("oda_no");
                    comboBox2.Items.Add(odaNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bags = "datasource=localhost;port=3306;username=root;password=3131";
            string Sorgu = "insert into yurtoto.ogrenci (öğr_ad, öğr_soyad, öğr_tc, öğr_telno, öğr_dg, öğr_mail, öğr_veliad, öğr_velitelno, öğr_veliadres, oda_no, bölüm_ad) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11);";
            MySqlConnection bagBase = new MySqlConnection(bags);
            MySqlCommand cmdBase = new MySqlCommand(Sorgu, bagBase);

            try
            {
                bagBase.Open();
                cmdBase.Parameters.AddWithValue("@p1", textBox1.Text);
                cmdBase.Parameters.AddWithValue("@p2", textBox2.Text);
                cmdBase.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                cmdBase.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
                cmdBase.Parameters.AddWithValue("@p5", maskedTextBox3.Text);
                cmdBase.Parameters.AddWithValue("@p6", textBox3.Text);
                cmdBase.Parameters.AddWithValue("@p7", textBox4.Text);
                cmdBase.Parameters.AddWithValue("@p8", maskedTextBox4.Text);
                cmdBase.Parameters.AddWithValue("@p9", richTextBox1.Text);
                cmdBase.Parameters.AddWithValue("@p10", comboBox2.Text);
                cmdBase.Parameters.AddWithValue("@p11", comboBox1.Text);

                if (cmdBase.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Öğrenci Kaydedildi");
                }
                else
                {
                    MessageBox.Show("Öğrenci Kaydedilmedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
