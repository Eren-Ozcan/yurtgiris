using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtdenemeicin
{
    public partial class Anasayfa : Form
    {
        private Button currentButton;
        private Form activeForm;

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.CadetBlue;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel3.BackColor = Color.CadetBlue;
                    panel1.BackColor = Color.CadetBlue;
                    butonkapat.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.LightSlateGray;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.ÖĞRENCİ_İŞLEMLERİ(), sender);

        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {


        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.İSTATİSTİKLER(), sender);
        }

        private void butonkapat_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }

        private void Reset()
        {
            DisableButton();
            label1.Text = "GİRİŞ";
            panel3.BackColor = Color.SlateGray;
            panel2.BackColor = Color.DarkSlateGray;
            panel1.BackColor = Color.LightSlateGray;
            currentButton = null;
            butonkapat.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.BÖLÜMLER(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.ÖDEMELER(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.YÖNETİCİ_İŞLEMLERİ(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.DİĞER_İŞLEMLER(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
