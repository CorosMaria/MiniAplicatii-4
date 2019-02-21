using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cercuri_aleatoare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i, x0, y0, w;
            System.Drawing.Graphics Desen;
            System.Random n;
            System.Drawing.Pen Creion_albastru;
            Desen = this.CreateGraphics();
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            n = new System.Random();
            w = 30;
            i = 0;
            do
            {
                x0 = n.Next(this.Width - w);
                y0 = n.Next(this.Height - w);
                Desen.DrawEllipse(Creion_albastru, x0, y0, w, w);
                i++;
            }
            while (i < 20);

        }
    }
}
