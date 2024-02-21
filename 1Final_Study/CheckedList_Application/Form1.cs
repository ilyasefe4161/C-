﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedList_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] languages = new[] {"C++", "C#", "Java", "Python", "Pascal", "C", "Java Script", "Assembly"};
            checkedListBox1.Items.AddRange(languages);
          
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
              //  checkedListBox1.SetItemChecked(i, true);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                // The indexChecked variable contains the index of the item.
                MessageBox.Show("Index: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
           
            }
        }
    }
}
