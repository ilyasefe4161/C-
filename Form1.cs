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

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection db = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\KBU\\Computer Engineering\\Third Year\\First Term\\Visual Programming\\C#\\project1\\database.accdb");


        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username_text.Text))
            {
                MessageBox.Show("Please enter your name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username_text.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password_text.Text))
            {
                MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_text.Focus();
                return;
            }
            try
            {
                db.Open();
                string username = username_text.Text;
                string password = password_text.Text;
                string login = "SELECT * FROM Users WHERE User_Name = '" + username_text.Text+"' AND Password = '"+password_text.Text+"'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(login, db);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    username = username_text.Text;
                    password = password_text.Text;
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.Close();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(username_text.Text))
                {
                    MessageBox.Show("Please enter your name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username_text.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(password_text.Text))
                {
                    MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password_text.Focus();
                    return;
                }
                try
                {
                    string username = username_text.Text.ToString();
                    string password = password_text.Text.ToString();

                    db.Open();
                    string insertQuery = "INSERT INTO Users (User_Name, [Password]) VALUES (?,?)";
                    OleDbCommand command = new OleDbCommand(insertQuery, db);
                    command.Parameters.AddWithValue("@User_Name", username);
                    command.Parameters.AddWithValue("@[Password]", password);
                    command.ExecuteNonQuery();
                    db.Close();
                    MessageBox.Show("You have been successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_text.UseSystemPasswordChar = false;
            }
            else
            {
                password_text.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
