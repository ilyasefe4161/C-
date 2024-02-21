using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Chart_Example_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\KBU\\Computer Engineering\\Third Year\\First Term\\Visual Programming\\C#\\1study\\Chart_Example_2\\OY.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            
            try {

               foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                Aconnection.Open();
                OleDbCommand AccessCommand = new OleDbCommand();
                AccessCommand.Connection = Aconnection;
                AccessCommand.CommandText = ("Select * from OY");
                OleDbDataReader read = AccessCommand.ExecuteReader();
                    
                while (read.Read())
                {

                    chart1.Series["OY"].Points.AddXY(read["Parti_Name"].ToString(), read["Oy_oran"].ToString());
                    chart1.Series["ChartDataSet"].Points.AddXY(read["Parti_Name"].ToString(), read["Oy_oran"].ToString());
                 
                }

                      Aconnection.Close();
                         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error"+ex);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oYDataSet.OY' table. You can move, or remove it, as needed.
            this.oYTableAdapter.Fill(this.oYDataSet.OY);

        }
    }
}
