using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            textBox1.PasswordChar= '*';
           
            




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.PasswordChar== '*') { 
            
            button2.BringToFront();
                textBox1.PasswordChar= '\0';
            
            
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.PasswordChar=='\0') {
                button1.BringToFront();
                textBox1.PasswordChar= '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();  
           
            
            if (textBox2.Text == "talon" && textBox1.Text == "talon123123")
            {
                form1.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect Password","Attention",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
