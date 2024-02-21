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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection db = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\KBU\\Computer Engineering\\Third Year\\First Term\\Visual Programming\\C#\\project1\\database.accdb");
        void show_records(string sqltext, OleDbConnection db)
        {
            db.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sqltext, db);
            DataSet ds = new DataSet();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables[0];
            db.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Personel' table. You can move, or remove it, as needed.
            //this.personelTableAdapter.Fill(this.databaseDataSet.Personel);
            show_records("Select * From Personel", db);
        }

        private void ShowGraphics_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ComeBack_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your full name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter your phone number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter your email.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please enter your address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            try
            {
                db.Open();
                string insertPersonel = "insert into Personel (FullName, PhoneNumber, Email, Address) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                OleDbCommand command = new OleDbCommand(insertPersonel, db);
                command.ExecuteNonQuery(); 
                db.Close();
                show_records("Select * From Personel", db);
                MessageBox.Show("You successfully saved your informations.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please enter a ID number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            try
            {
                db.Open();
                string deletePersonel = "delete from Personel where ID=" + textBox5.Text + "";
                OleDbCommand command = new OleDbCommand(deletePersonel, db);
                command.ExecuteNonQuery();
                MessageBox.Show("You successfully deleted your informations.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            db.Close();
            show_records("Select * From Personel", db);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand searchPersonel = new OleDbCommand ("select * from Personel where FullName = '" + textBox1.Text+"'", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(searchPersonel);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Open();
            OleDbCommand update = new OleDbCommand("UPDATE Personel SET PhoneNumber = '"+textBox2.Text+"', Email = '"+textBox3.Text+"', Address = '"+textBox4.Text+ "' WHERE FullName = '"+textBox1.Text+"';", db);
            update.ExecuteNonQuery();
            db.Close();
            show_records("Select * From Personel", db);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
