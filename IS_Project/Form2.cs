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
    public partial class Form2 : Form
    {
        public static string dir = String.Empty;
        public static string per = String.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Form1.admin == 1)
            {
                splitContainer1.Panel1.Hide();
            }
            if(Form1.admin == 0)
            {
                splitContainer1.Panel2.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.user != textBox2.Text)
            {
                StreamReader r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\files.txt");
                string files = r.ReadToEnd();
                r.Close();
                r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\users.txt");
                string users = r.ReadToEnd();
                r.Close();
                if (Form1.admin == 1)
                {
                    r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\permissions.txt");
                    string permissions;
                    permissions = r.ReadToEnd();
                    r.Close();
                    StreamWriter w;
                    if ((files.Contains(textBox1.Text + " ") || files.Contains(" " + textBox1.Text)) && users.Contains(textBox2.Text + ","))
                    {
                        if (permissions.Contains(textBox2.Text + "," + textBox1.Text))
                        {
                            MessageBox.Show("Already Access Granted");
                        }
                        else if (!permissions.Contains(textBox2.Text + "," + textBox1.Text))
                        {
                            w = new StreamWriter(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\permissions.txt", append: true);
                            w.WriteLine(textBox2.Text + "," + textBox1.Text);
                            w.Close();
                            MessageBox.Show("Access Granted To The User");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or File Name . . . ! ! !");
                    }
                }
            }
            else
            {
                MessageBox.Show("You Can't Assign Permission To Yourself");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Form1.user != textBox2.Text)
            {
                StreamReader r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\files.txt");
                string files = r.ReadToEnd();
                r.Close();
                r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\users.txt");
                string users = r.ReadToEnd();
                r.Close();
                r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\permissions.txt");
                string permissions;
                permissions = r.ReadToEnd();
                r.Close();
                if (Form1.admin == 1)
                {
                    StreamWriter w;
                    if ((files.Contains(textBox1.Text + " ") || files.Contains(" " + textBox1.Text)) && users.Contains(textBox2.Text + ","))
                    {
                        if (!permissions.Contains(textBox2.Text + "," + textBox1.Text))
                        {
                            MessageBox.Show("Already Access Denied");
                        }
                        else if (permissions.Contains(textBox2.Text + "," + textBox1.Text))
                        {
                            string newLine = Environment.NewLine;
                            w = new StreamWriter(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\permissions.txt");
                            permissions = permissions.Replace(textBox2.Text + "," + textBox1.Text + newLine, "");
                            w.Write(permissions);
                            w.Close();
                            MessageBox.Show("Access Denied To The User");
                        }
                        /*else
                        {
                            w = new StreamWriter(@"C:\Users\Farzeel Ahmad\Desktop\IS_Project\IS_Project\bin\Debug\permissions.txt", append: true);
                            w.WriteLine(textBox2.Text + "," + textBox1.Text + "," + "denied");
                            w.Close();
                            MessageBox.Show("Access Denied To The User");
                        }*/
                        Form1 f1 = new Form1();
                        f1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or File Name . . . ! ! !");
                    }
                }
            }
            else
            {
                MessageBox.Show("You Can't Assign Permission to Yourself");
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    StreamReader r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\permissions.txt");
        //    string text = r.ReadToEnd();
        //    if(text.Contains(Form1.user + "," + textBox3.Text))
        //    {
        //        MessageBox.Show("You Have Access");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Access Denied");
        //    }
        //    r.Close();
        //}

        private void File1_Click(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\permissions.txt");
            string text = r.ReadToEnd();
            
            if (text.Contains(Form1.user + "," + "Dir1") || Form1.admin == 1)
            {
            
            if(Form1.admin == 1)
            {
                    dir = "Dir1";
            }
            else
             {
                    per = "Dir1";
            }
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
            }
            else
            {
                MessageBox.Show("You are not given access to this folder");
            }
        }

        private void File2_Click(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\permissions.txt");
            string text = r.ReadToEnd();

            if (text.Contains(Form1.user + "," + "Dir2") || Form1.admin == 1)
            {
                if (Form1.admin == 1)
                {
                    dir = "Dir2";
                }
                else
                {
                    per = "Dir2";
                }
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                MessageBox.Show("You are not given access to this folder");
            }
        }
    }
}
