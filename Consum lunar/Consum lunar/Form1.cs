using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consum_lunar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            const int nr_z = 31;
            int poz_x = 14; // pozitia curenta pe axa x
            float w_r = 1, w_a = 3; // grosimea(in pixeli) a liniei rosii respectiv albastre
            float[] consum = new float[nr_z];// // vector ce pastreaza consumurile pe nr_z zile
            float v_rand; // valoare aleatoare
            float c_lun; // consum lunar
            float c_med; // consum lunar mediu
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_rosu;
            Creion_rosu = new System.Drawing.Pen(System.Drawing.Color.Red, w_r);
            System.Drawing.Pen Creion_albastru;
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue, w_a);
            System.Random n = new System.Random();
            Desen.Clear(this.BackColor);
            Desen.DrawLine(Creion_rosu, 6, 0, 6, this.Height - 40);
            Desen.DrawLine(Creion_rosu, 6, this.Height - 40, this.Width - 20, this.Height - 40);
            for (i = 0; i < nr_z; i++)
            {
                v_rand = n.Next(this.Height - 40);// se genereaza o valoare aleatoare
                Desen.DrawLine(Creion_albastru, poz_x, this.Height - 40, poz_x, Height - 40 - v_rand);
                poz_x += 14;
                consum[i] = v_rand;
            }
            c_lun = 0;
            for (i = 0; i < nr_z; i++)
            {
                c_lun = c_lun + consum[i];
            }
            //calculez si afisez consumul mediu
            c_med = c_lun / nr_z;
            Desen.DrawLine(Creion_rosu, 6, this.Height - 40 - c_med, this.Width - 20, this.Height - 40 - c_med);
        }
    }
}
