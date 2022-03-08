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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addplayer = new addplayer();
            addplayer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addteam = new addteam();
            addteam.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addgame_21_ = new addgame_21_();
            addgame_21_.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form3 = new Form3();
            form3.Show();
        }
    }
}
