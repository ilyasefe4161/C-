using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //We added the library.




namespace AccessConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\members.accdb");
        
        private void showInformation()
        {
            listView1.Items.Clear();
            Aconnection.Open();
            OleDbCommand AccessCommand = new OleDbCommand();
            AccessCommand.Connection = Aconnection;
            AccessCommand.CommandText = ("select * from members");
            OleDbDataReader read = AccessCommand.ExecuteReader();

            while (read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["ID"].ToString();
                addNew.SubItems.Add (read["mName"].ToString());
                addNew.SubItems.Add(read["Surname"].ToString());
                addNew.SubItems.Add(read["mail"].ToString());
                addNew.SubItems.Add(read["mPosition"].ToString());

                listView1.Items.Add(addNew);
            }
            Aconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aconnection.Open();
            string sqlText = "INSERT INTO members (mName,Surname,mail,mPosition) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.SelectedItem.ToString() + "')";
            OleDbCommand AccessCommand = new OleDbCommand(sqlText, Aconnection);
            AccessCommand.ExecuteNonQuery();
            Aconnection.Close();

            showInformation();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


