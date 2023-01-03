using System.Linq;

namespace deneme
{
    
    public partial class Form1 : Form
    {
       
         

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void AD_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row_number=listBox1.SelectedIndex;
            listBox2.SelectedIndex = row_number;
            listBox3.SelectedIndex = row_number;
            listBox4.SelectedIndex= row_number;
            listBox5.SelectedIndex= row_number;
            listBox6.SelectedIndex = row_number;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row_number = listBox1.SelectedIndex;
            listBox2.SelectedIndex = row_number;
            listBox3.SelectedIndex = row_number;
            listBox4.SelectedIndex = row_number;
            listBox5.SelectedIndex = row_number;
            listBox6.SelectedIndex = row_number;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row_number = listBox1.SelectedIndex;
            listBox2.SelectedIndex = row_number;
            listBox3.SelectedIndex = row_number;
            listBox4.SelectedIndex = row_number;
            listBox5.SelectedIndex = row_number;
            listBox6.SelectedIndex = row_number;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row_number = listBox1.SelectedIndex;
            listBox2.SelectedIndex = row_number;
            listBox3.SelectedIndex = row_number;
            listBox4.SelectedIndex = row_number;
            listBox5.SelectedIndex = row_number;
            listBox6.SelectedIndex = row_number;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row_number = listBox1.SelectedIndex;
            listBox2.SelectedIndex = row_number;
            listBox3.SelectedIndex = row_number;
            listBox4.SelectedIndex = row_number;
            listBox5.SelectedIndex = row_number;
            listBox6.SelectedIndex = row_number;
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            
            

           
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter students name","Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        else if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter students surname", "Attention", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        else if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter students ID number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        else if(radioButton1.Checked==false && radioButton2.Checked==false)
            {
                MessageBox.Show("Please select students gender", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        else if (comboBox1.SelectedItem == null || comboBox1.SelectedItem == "")
            {
                MessageBox.Show("Please enter students section", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox2.SelectedItem == null || comboBox2.SelectedItem == "")
            {
                MessageBox.Show("Please enter students registration year", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBox6.FindString(textBox3.Text) != -1)
            {
                MessageBox.Show("Student already registered", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            






            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox2.Text);
                if(radioButton1.Checked== true)
                {
                    listBox5.Items.Add("MAN");
                }
                else if(radioButton2.Checked== true)
                {
                    listBox5.Items.Add("WOMAN");
                }


               
                listBox3.Items.Add(comboBox1.Text);
             listBox4.Items.Add(comboBox2.Text);
                listBox6.Items.Add(textBox3.Text);
                
               
               
                
                

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
                

                

               
            
            }
        
        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row_number=listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(row_number);
            listBox2.Items.RemoveAt(row_number);
            listBox3.Items.RemoveAt(row_number);
            listBox4.Items.RemoveAt(row_number);
            listBox5.Items.RemoveAt(row_number);
            listBox6.Items.RemoveAt(row_number);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            
            
            


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        protected void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row_number = listBox1.SelectedIndex;
            listBox2.SelectedIndex = row_number;
            listBox3.SelectedIndex = row_number;
            listBox4.SelectedIndex = row_number;
            listBox5.SelectedIndex = row_number;
            listBox6.SelectedIndex = row_number;
        }
    }
}