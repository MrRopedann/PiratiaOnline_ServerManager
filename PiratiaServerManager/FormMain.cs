using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiratiaServerManager
{
    public partial class FormMain : Form
    {
        bool hideMenu = true;
        string buttonText = "";
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hideMenu)
            {
                leftMenu.Width = 50;
                buttonText = button1.Text;
                button1.Text = "";
                pictureBox1.Image = Properties.Resources.pkodevlogo_min;
                hideMenu = false;
            }
            else
            {
                leftMenu.Width = 270;
                button1.Text = buttonText;
                buttonText = "";
                pictureBox1.Image = Properties.Resources.pkodevlogo_full_png_9c0b058fcf0ebbfd09e443f272c3d328;
                hideMenu = true;
            }
        }
    }
}
