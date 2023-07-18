using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int saniye = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = saniye.ToString();
            saniye--;

            if (sayac == 0)
            {
                button1.BackColor = Color.Red;
                saniye = 45;


            }
            if (sayac == 30)
            {
                button2.BackColor = Color.Yellow;

            }



            if (sayac == 45)
            {
                button3.BackColor = Color.Green;
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                saniye = 30;

            }

            if (sayac == 75)
            {
                sayac = 0;
                button3.BackColor = Color.Gray;
                button1.BackColor = Color.Red;
                saniye = 45;


            }

            sayac++;

        }
    }
}
