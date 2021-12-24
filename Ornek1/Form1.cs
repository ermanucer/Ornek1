using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Görev 1 : Yaşını hesaplayınız.
            DateTime dt = dtpDogumTarihi.Value;

            int ay = Convert.ToInt32(dtpDogumTarihi.Value.Month);
            int gun = Convert.ToInt32(dtpDogumTarihi.Value.Day);

            TimeSpan gecenSure = DateTime.Now - dt;
            lblYasananGun.Text= "Yaşadığınız Gün : " + ((int)(gecenSure.TotalDays)).ToString();
            lblYas.Text = "Yaşınız :" + (DateTime.Now.Year - dt.Year).ToString();
            if ((ay == 1 && gun > 20) || (ay == 2 && gun < 20))
                lblBurc.Text = "Burcunuz : " + "Kova";
            else if ((ay == 2 && gun > 18) || (ay == 3 && gun < 21))
                lblBurc.Text = "Burcunuz : " + "Balık";
            else if ((ay == 3 && gun > 20) || (ay == 4 && gun < 21))
                lblBurc.Text = "Burcunuz : " + "Koç";
            else if ((ay == 4 && gun > 20) || (ay == 5 && gun < 22))
                lblBurc.Text = "Burcunuz : " + "Boğa";
            else if ((ay == 5 && gun > 21) || (ay == 6 && gun < 22))
                lblBurc.Text = "Burcunuz : " + "İkizler";
            else if ((ay == 6 && gun > 21) || (ay == 7 && gun < 24))
                lblBurc.Text = "Burcunuz : " + "Yengeç";
            else if ((ay == 7 && gun > 23) || (ay == 8 && gun < 24))
                lblBurc.Text = "Burcunuz : " + "Aslan";
            else if ((ay == 8 && gun > 23) || (ay == 9 && gun < 24))
                lblBurc.Text = "Burcunuz : " + "Başak";
            else if ((ay == 9 && gun > 23) || (ay == 10 && gun < 24))
                lblBurc.Text = "Burcunuz : " + "Terazi";
            else if ((ay == 10 && gun > 23) || (ay == 11 && gun < 23)) 
                lblBurc.Text = "Burcunuz : " + "Akrep";
            else if ((ay == 11 && gun > 22) || (ay == 12 && gun < 23))
                lblBurc.Text = "Burcunuz : " + "Yay";
            else if ((ay == 12 && gun > 22) || (ay == 1 && gun < 21))
                lblBurc.Text = "Burcunuz : " + "Oğlak";

        }
    }
}
