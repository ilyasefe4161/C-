﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barCode = textBox1.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode =
                Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = brCode.Draw(barCode, 60);
            }
            catch (Exception)
            {

            }
        }
    }
}
