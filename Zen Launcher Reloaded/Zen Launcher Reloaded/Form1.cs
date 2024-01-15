using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zen_Launcher_Reloaded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("C:\\Users\\Anshuman\\Downloads\\icons8-male-user-material-filled\\w3.png");
           
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
          
            pictureBox3.Image = Image.FromFile("C:\\Users\\Anshuman\\Downloads\\icons8-male-user-material-filled\\c3.png");
           
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
          
            pictureBox2.Image = Image.FromFile("C:\\Users\\Anshuman\\Downloads\\icons8-male-user-material-filled\\w2.png");

          
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Users\\Anshuman\\Downloads\\icons8-male-user-material-filled\\icons8-collection-96.png");

         
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(panel4);
            bunifuTransition3.ShowSync(panel9);

            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();

            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            
            bunifuTransition3.HideSync(panel9);
            bunifuTransition1.HideSync(panel4);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(panel5);
            bunifuTransition3.ShowSync(panel10);

            panel4.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();

            panel9.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(panel10);
            bunifuTransition1.HideSync(panel5);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(panel6);
            bunifuTransition3.ShowSync(panel11);

            panel5.Hide();
            panel4.Hide();
            panel7.Hide();
            panel8.Hide();

            panel10.Hide();
            panel9.Hide();
            panel12.Hide();
            panel13.Hide();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(panel11);
            bunifuTransition1.HideSync(panel6);
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(panel7);
            bunifuTransition3.ShowSync(panel12);

            panel5.Hide();
            panel6.Hide();
            panel4.Hide();
            panel8.Hide();

            panel10.Hide();
            panel11.Hide();
            panel9.Hide();
            panel13.Hide();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(panel12);
            bunifuTransition1.HideSync(panel7);
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(panel8);
            bunifuTransition3.ShowSync(panel13);

            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel4.Hide();

            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel9.Hide();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(panel13);
            bunifuTransition1.HideSync(panel8);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
