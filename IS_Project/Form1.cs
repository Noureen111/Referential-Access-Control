using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Project
{
    public partial class Form1 : Form
    {
        public static int admin = 0;
        public static string user = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string[] arr = { "", "" };
            StreamReader r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\users.txt");
            string text = r.ReadLine();
            arr = text.Split(',');
            user = textBox1.Text;
            if (textBox1.Text + "," + textBox2.Text == text)
            {
                admin = 1;
                flag = 1;
                MessageBox.Show("Admin Logged In");
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                //this.Hide();
            }
            else
            {
                while (!r.EndOfStream)
                {
                    text = r.ReadLine();
                    if (textBox1.Text + "," + textBox2.Text == text)
                    {
                        admin = 0;
                        flag = 1;
                        user = textBox1.Text;
                        MessageBox.Show("User Logged In");
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.Show();
                        //this.Hide();
                    }
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("Invalid User Name . . . ! ! !");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
