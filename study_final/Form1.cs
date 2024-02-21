using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Blue;

            Button Mybutton = new Button();
            //Set the location of the button
             Mybutton.Location = new Point(225, 198);
            // Set text inside the button
            Mybutton.Text = "ENTER";
            // Set the AutoSize property of the button
            Mybutton.AutoSize = true;
            // Set the background color of the button
            Mybutton.BackColor = Color.LightBlue;
            // Set the padding of the button
            Mybutton.Padding = new Padding(6);
            // Set font of the text present in the button
            Mybutton.Font = new Font("French Script MT", 18);
            //Add this Button to form
            this.Controls.Add(Mybutton);

            Button Mybutton1 = new Button();
            Mybutton1.Location = new Point(360, 198);
            Mybutton1.Text = "Cancel";
            Mybutton1.AutoSize = true;
            Mybutton1.BackColor = Color.LightPink;
            Mybutton1.Padding = new Padding(6);
            Mybutton1.Font = new Font("French Script MT", 18);
            this.Controls.Add(Mybutton1);

            Label Mylablel1 = new Label();
            Mylablel1.Location = new Point(1, 1);
            Mylablel1.Text = "Enter Name";
            Mylablel1.AutoSize = true;
            Mylablel1.BackColor = Color.LightGray;
            // Add this label to form
            this.Controls.Add(Mylablel1);

            // Creating and setting the properties of TextBox1
            TextBox Mytextbox1 = new TextBox();
            Mytextbox1.Location = new Point(90, 1);
            Mytextbox1.BackColor = Color.LightGray;
            Mytextbox1.AutoSize = true;
            Mytextbox1.Name = "text_box1";
            // Add this textbox to form
            this.Controls.Add(Mytextbox1);
            // Creating and setting the properties of Lable1
            Label Mylablel2 = new Label();
            Mylablel2.Location = new Point(1, 25);
            Mylablel2.Text = "Enter Password";
            Mylablel2.AutoSize = true;
            Mylablel2.BackColor = Color.LightGray;
            this.Controls.Add(Mylablel2);
            // Creating and setting the properties of TextBox2
            TextBox Mytextbox2 = new TextBox();
            Mytextbox2.Location = new Point(90, 25);
            Mytextbox2.BackColor = Color.LightGray;
            Mytextbox2.AutoSize = true;
            Mytextbox2.PasswordChar = '^';
            Mytextbox2.Name = "text_box2";

            //to make private text
            Mytextbox2.UseSystemPasswordChar = true;
            // Add this textbox to form
            this.Controls.Add(Mytextbox2);

            TextBox Mytextbox = new TextBox();
            Mytextbox.Location = new Point(200, 200);
            Mytextbox.BackColor = Color.LightGray;
            Mytextbox.ForeColor = Color.DarkOliveGreen;
            Mytextbox.Height = 100;
            Mytextbox.Width = 200;
            Mytextbox.Name = "text_box1";

            //to make more row
            Mytextbox.Multiline = true;
            Mytextbox.ScrollBars = ScrollBars.Vertical;
            Mytextbox.CharacterCasing = CharacterCasing.Upper;
            // Add this textbox to form
            this.Controls.Add(Mytextbox);

            RadioButton r1 = new RadioButton();
            r1.AutoSize = true;
            r1.Text = "Intern";
            r1.Location = new Point(200, 75); r1.Font = new Font("Berlin Sans FB", 12);
            //r1.Checked = true;
            // Adding this label to the form
            this.Controls.Add(r1);
            // Creating and setting the
            // properties of the RadioButton
            RadioButton r2 = new RadioButton();
            r2.AutoSize = true;
            r2.Text = "Team Leader";
            r2.Location = new Point(300, 75);
            r2.Font = new Font("Berlin Sans FB", 12);
            // Adding this label to the form
            this.Controls.Add(r2);
            // Creating and setting the
            // properties of the RadioButton
            RadioButton r3 = new RadioButton();
            r3.AutoSize = true;
            r3.Text = "Software Engineer";
            r3.Location = new Point(450, 75);
            r3.Font = new Font("Berlin Sans FB", 12);
            //r3.Checked = true;
            // Adding this label to the form
            this.Controls.Add(r3);


            // Creating and setting the properties of label
            Label l1 = new Label();
            l1.Location = new Point(30, 50);
            l1.AutoSize = true;
            l1.Text = "Select Programming Language";
            // Adding this label to the form
            this.Controls.Add(l1);
            // Creating and setting the properties of comboBox
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(200, 50);
            mybox.Size = new Size(216, 26);
            mybox.Items.Add("C#");
            mybox.Items.Add("Java");
            mybox.Items.Add("Scala");
            mybox.Items.Add("C");
            mybox.Items.Add("C++");
            mybox.Sorted = true;
            // Adding this ComboBox to the form
            this.Controls.Add(mybox);

            ComboBox comboBox1 = new ComboBox();
            comboBox1.Items.Add("weekdays");
            comboBox1.Items.Add("year");
            comboBox1.Location = new Point(200, 2);

            this.Controls.Add(comboBox1);


        }
    }
}
