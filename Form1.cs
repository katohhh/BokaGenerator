using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace HypeSquad_changer
{
    public partial class FormUno : Form
    {
        public FormUno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread(); 
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized; 
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void guna2GradientButton3_Click(object sender, System.EventArgs e)
            
        {


            if (Control.ModifierKeys == Keys.Control)
            {
                ((Control)sender).Hide();
                ((Control)sender).Show();
            }
            guna2GradientButton3.Text = "Authenticated";
            MessageBox.Show("Succefully Authenticated!", "BokaGeneratorSecurity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Welcome to BokaGenerator!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new Form2().ShowDialog();

            

            

        }
    }
}
