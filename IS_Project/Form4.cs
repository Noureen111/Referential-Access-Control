using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Project
{
    public partial class Form4 : Form
    {
        public static string quantity;
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            if (f == String.Empty)
            {
                MessageBox.Show("Enter filename");
            }
            else { 

            string folder = "";
            if (Form2.dir == "Dir1" || Form2.per == "Dir1")
            {
                folder = @"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol1";

            }
            else if (Form2.dir == "Dir2" || Form2.per == "Dir2")
            {
                folder = @"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol2";

            }

            string fileName = Path.Combine(folder, f + ".txt");
            quantity = fileName;
            if (!File.Exists(fileName))
            {
                using (FileStream fs = File.Create(fileName))
                {
                }

                MessageBox.Show("File Created Successfully!!");
            }
            else
            {

                MessageBox.Show("File Already Existed!!");
            }
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string folder = "";
            string f = textBox1.Text;
            if (f == String.Empty)
            {
                MessageBox.Show("Enter filename");
            }
            else { 
            if (Form2.dir == "Dir1" || Form2.per == "Dir1")
            {
                folder = @"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol1";

            }
            else if (Form2.dir == "Dir2" || Form2.per == "Dir2")
            {
                folder = @"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol2";

            }
            string fileName = Path.Combine(folder, f + ".txt");
            quantity = fileName;
            File.Delete(fileName);

            Form3 f3 = new Form3();
            this.Hide();

            MessageBox.Show("File Deleted Successfully!!");
            f3.Show();
        }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string folder = "";
            string f = textBox1.Text;
            if (f == String.Empty)
            {
                MessageBox.Show("Enter filename");
            }
            else
            {
                if (Form2.dir == "Dir1" || Form2.per == "Dir1")
                {
                    folder = @"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol1";

                }
                else if (Form2.dir == "Dir2" || Form2.per == "Dir2")
                {
                    folder = @"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol2";

                }

                string fileName = Path.Combine(folder, f + ".txt");
             //   MessageBox.Show(fileName);
                quantity = fileName;
                Form5 frm2 = new Form5();
                this.Hide();
                frm2.Show();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            string folder = "";
            string f = textBox1.Text;
            if (f == String.Empty)
            {
                MessageBox.Show("Enter filename");
            }
            else
            {
                if (Form2.dir == "Dir1" || Form2.per == "Dir1")
                {
                    folder = @"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol1";

                }
                else if (Form2.dir == "Dir2" || Form2.per == "Dir2")
                {
                    folder = @"C:\Users\Amna\Downloads\IS\IS_Project\IS_Project\fol2";

                }
                // write file
                string fileName = Path.Combine(folder, f + ".txt");
                quantity = fileName;
                //  System.Diagnostics.Process.Start("notepad.exe", fileName);
                Form6 f6 = new Form6(fileName);
                this.Hide();
                f6.Show();
            }
        }      
        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f4 = new Form3();
            f4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
