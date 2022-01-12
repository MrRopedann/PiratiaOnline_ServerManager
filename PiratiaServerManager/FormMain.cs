using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLua;

namespace PiratiaServerManager
{
    public partial class FormMain : Form
    {
        bool hideMenu = true;
        string buttonText = "";
        public FormMain()
        {
            InitializeComponent();
            Lua nLua = new Lua();
            nLua.DoFile(@"./Language/rus.lua");
            LuaFunction func = nLua["langusage"] as LuaFunction;
            var temp = func.Call();

            comboBox1.Text = "Русский";
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Русский")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            }
            else if (comboBox1.Text == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            }
        }
    }
}
