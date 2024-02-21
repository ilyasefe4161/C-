using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button_Lesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox1.Text = "Engineer is selected.";
            else if (radioButton2.Checked == true)
                textBox1.Text = "Manager is selected.";
            else if (radioButton3.Checked == true)
                textBox1.Text = "Technician is selected.";
            else textBox1.Text ="None of them is selected.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
