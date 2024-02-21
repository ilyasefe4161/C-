using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //We added the lilbrary.

namespace DataGridAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection dc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\KBU\\Computer Engineering\\Third Year\\First Term\\Visual Programming\\C#\\1Final_Study\\DataGridAccess\\DataGridAccess\\db.accdb");
        //dc: database connection

        private void showRecords(string mRecords, OleDbConnection dc)
        {
            dc.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(mRecords, dc);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            ////To change Column name
            //dataGridView1.Columns[1].HeaderText = "Name";
            //dataGridView1.Columns[2].HeaderText = "Surname";
            //dataGridView1.Columns[3].HeaderText = "Mail";
            //dataGridView1.Columns[4].HeaderText = "Position";
            dc.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showRecords("Select * from Personel", dc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dc.Open();

                string sqlText = "INSERT INTO Personel (Name, Surname, Mail, Position) VALUES (@mName, @mSurname, @mMail, @mPosition)";
                OleDbCommand ac = new OleDbCommand(sqlText, dc);

                // Parametreleri eklerken @ işaretini kullanın.
                ac.Parameters.AddWithValue("@mName", textBox1.Text);
                ac.Parameters.AddWithValue("@mSurname", textBox2.Text);
                ac.Parameters.AddWithValue("@mMail", textBox3.Text);

                // ComboBox'da seçili öğe kontrolü ekleyin.
                if (comboBox1.SelectedItem != null)
                {
                    ac.Parameters.AddWithValue("@mPosition", comboBox1.SelectedItem.ToString());
                }
                ac.ExecuteNonQuery();
                dc.Close();
                showRecords("Select * from Personel",dc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Refresh();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            dc.Open();
            string sqlText = "delete from Personel where ID=@id";
            OleDbCommand ac = new OleDbCommand(sqlText, dc);
            ac.Parameters.AddWithValue("@id", textBox5.Text);
            ac.ExecuteNonQuery();
            dc.Close();
            showRecords("Select * from Personel",dc);
            textBox5.Clear();
        }
    }
}
