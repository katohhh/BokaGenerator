using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace HypeSquad_changer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            guna2HtmlLabel2.Text = $"Number of Threads: {guna2TrackBar1.Value}";
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch
            {

            }
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
    
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

            
            try
            {
                Close();

            }
            catch
            {
                new FormUno().ShowDialog(); 

            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

        }
    }
}
