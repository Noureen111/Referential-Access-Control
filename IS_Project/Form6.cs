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
    public partial class Form6 : Form
    {
        public Form6(string file)
        {

            InitializeComponent();
            string content = File.ReadAllText(Form4.quantity);
            if(content != "")
            {

            richTextBox1.Text = content;
            }
           

        }
         private void add (string path)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            string t = Form4.quantity;
            
            using (StreamWriter allText = new StreamWriter(t, false))
            {
                allText.Write(richTextBox1.Text);
            }
            MessageBox.Show("File Saved");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
