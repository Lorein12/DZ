using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form

    {
        int index = 0;

        string[] imagelist = new string[]
        {
            "1.png","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg"
        };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form3 = new Form3();
            form3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            index--;
            if (index < imagelist.Length) index = 0;
            pictureBox2.Load("../../../photos/" + imagelist[index + 0]);
            pictureBox3.Load("../../../photos/" + imagelist[index + 1]);
            pictureBox4.Load("../../../photos/" + imagelist[index + 2]);

            return;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            index=index+3;
            if (index +3> imagelist.Length) index = 0;
            pictureBox2.Load("../../../photos/" + imagelist[index + 0]);
            pictureBox3.Load("../../../photos/" + imagelist[index + 1]);
            pictureBox4.Load("../../../photos/" + imagelist[index + 2]);

            return;

            



        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Load("../../../photos/" + imagelist[0]);
            pictureBox3.Load("../../../photos/" + imagelist[1]);
            pictureBox4.Load("../../../photos/" + imagelist[2]);
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
