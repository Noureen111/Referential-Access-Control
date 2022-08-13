using System.IO;
using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\bin\Debug\permissions.txt");
            string text = r.ReadToEnd();
            string[] filePaths= {"0" };
            int length =0;
            if (text.Contains(Form1.user + "," + "Dir1") || Form2.dir == "Dir1")
            {

            filePaths = Directory.GetFiles(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol1\", "*.txt",
                                         SearchOption.TopDirectoryOnly);
                length = filePaths.Length;
            }
            else if (text.Contains(Form1.user + "," + "Dir2") || Form2.dir == "Dir2")
            {

                filePaths = Directory.GetFiles(@"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol2\", "*.txt",
                                             SearchOption.TopDirectoryOnly);
                length = filePaths.Length;
            }
            for (int i = 0; i < length; i++)
            {

                //Create label
                Label label = new Label();
                label.Text = Path.GetFileName(filePaths[i]);
                label.Location = new Point(90, 90);
              //  label.MaximumSize = new Size(200,25);
               // label.Size = new Size(1000000000, 100);
                label.Left = 10;
                label.Top = (i + 1) * 20;
                //label.AutoSize = true;
                label.Width = 10000;
                label.Font = new Font("Arial", 8, FontStyle.Regular);
              //  label.Font.Size = 20;
                //while (label.Width >= TextRenderer.MeasureText(label.Text,
                //                                    new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Width)
                //{
                //    label.Font = new Font(label.Font.FontFamily, label.Font.Size - 0.5f, label.Font.Style);
                //}
                //Position label on screen

                //Create textbox
                //TextBox textBox = new TextBox();
                //Position textbox on screen
                // textBox.Left = 120;
                //    textBox.Top = (i + 1) * 20;
                //Add controls to form
                this.Controls.Add(label);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f3 = new Form4();
            f3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f3 = new Form4();
            f3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f3 = new Form4();
            f3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f3 = new Form4();
            f3.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
