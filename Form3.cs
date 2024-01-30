using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection db = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\KBU\\Computer Engineering\\Third Year\\First Term\\Visual Programming\\C#\\project1\\database.accdb");
        private void Form3_Load(object sender, EventArgs e)
        {
            db.Open();
            OleDbCommand graphicdb = new OleDbCommand("SELECT Gender, COUNT(*) FROM Personel group by Gender", db);
            OleDbDataReader read = graphicdb.ExecuteReader();
            while (read.Read())
            {
                Chart.Series["ies Computer & Software"].Points.AddXY(read[0].ToString(), read[1]);
            }
            db.Close();

            //Chart.Series["Man"].Points.AddXY("ies Computer and Software", 3);
            //Chart.Series["Man"].Points.AddXY("Sar Cam", 73);
            //Chart.Series["Man"].Points.AddXY("Çoban Pen", 26);
            //Chart.Series["Woman"].Points.AddXY("ies Computer and Software", 3);
            //Chart.Series["Woman"].Points.AddXY("Sar Cam", 56);
            //Chart.Series["Woman"].Points.AddXY("Çoban Pen", 42);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
