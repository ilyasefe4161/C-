using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox_2_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("days");
            comboBox1.Items.Add("year");
            comboBox1.Items.Add("time");

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("days"))
            {
                comboBox2.Items.Add("Sunday");
                comboBox2.Items.Add("Monday");
                comboBox2.Items.Add("Tuesday");
                comboBox2.Items.Add("Wednesday");
                comboBox2.Items.Add("Thursday");
                comboBox2.Items.Add("Friday");
                comboBox2.Items.Add("Saturday");
                
            }
            
            else if (comboBox1.SelectedItem.Equals("year"))
            {
                
                comboBox2.Items.Add("2012");
                comboBox2.Items.Add("2013");
                comboBox2.Items.Add("2014");
                comboBox2.Items.Add("2015");
                comboBox2.Items.Add("2016");
                comboBox2.Items.Add("2017");
            }
            else if (comboBox1.SelectedItem.Equals("time"))
            {
                comboBox2.Items.Add("00.00");
                comboBox2.Items.Add("01.00");
                comboBox2.Items.Add("02.00");
                comboBox2.Items.Add("03.00");
                comboBox2.Items.Add("04.00");
                comboBox2.Items.Add("05.00");
                comboBox2.Items.Add("06.00");   
            }

            //MessageBox.Show(comboBox1.Text + " is selected");
            //MessageBox.Show(comboBox2.Text + " is selected");
        }


    }
}

