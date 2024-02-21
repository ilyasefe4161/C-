using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chart_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oy_Oran.Series["Oy"].Points.AddXY("A", 20);
            Oy_Oran.Series["Oy"].Points.AddXY("B", 10);
            Oy_Oran.Series["Oy"].Points.AddXY("C", 30);
            Oy_Oran.Series["Oy"].Points.AddXY("D", 15);
            Oy_Oran.Series["Oy"].Points.AddXY("E", 5);
            Oy_Oran.Series["Oy"].Points.AddXY("F", 20);
        }

        private void Oy_Oran_Click(object sender, EventArgs e)
        {
            //        Oy_Oran.Series["Oy"].Points.AddXY("A", 100);
            //        Oy_Oran.Series["Oy"].Points.AddXY("B", 100);
            //        Oy_Oran.Series["Oy"].Points.AddXY("C", 300);
            //        Oy_Oran.Series["Oy"].Points.AddXY("D", 150);
            //        Oy_Oran.Series["Oy"].Points.AddXY("E", 50);
            //        Oy_Oran.Series["Oy"].Points.AddXY("F", 200);
        }
    }
}
