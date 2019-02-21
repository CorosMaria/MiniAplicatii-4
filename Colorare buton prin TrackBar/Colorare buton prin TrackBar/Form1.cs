using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colorare_buton_prin_TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void tkBR_ValueChanged(object sender, EventArgs e)
        {
            coloreaza();
        }
        public void coloreaza()
        {
        Color myRgbColor = new Color();
        myRgbColor = Color.FromArgb(tkBR.Value, tkBG.Value, tkBB.Value);
        this.button1.BackColor = myRgbColor;
        }

        private void tkBG_ValueChanged(object sender, EventArgs e)
        {
            coloreaza();
        }

        private void tkBB_ValueChanged(object sender, EventArgs e)
        {
            coloreaza();
        }

    }
}
