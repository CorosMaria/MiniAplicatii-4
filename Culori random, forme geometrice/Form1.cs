using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            bool repeta = true;
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_rosu;
            System.Drawing.Pen Creion_albastru;
            System.Random n = new System.Random();
            Desen.Clear(this.BackColor);
                i = 0;
                for (i = 1; i <= 100; i++)
                {
                    Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.FromArgb(n.Next(256), n.Next(256), n.Next(256)));
                    Creion_rosu = new System.Drawing.Pen(System.Drawing.Color.FromArgb(n.Next(256), n.Next(256), n.Next(256)));
                    Desen.DrawRectangle(Creion_albastru, n.Next(this.Width), n.Next(this.Height), n.Next(75), n.Next(50));
                    Desen.DrawEllipse(Creion_rosu, n.Next(this.Width), n.Next(this.Height), n.Next(50), n.Next(75));
                }
            }
        }
    }
