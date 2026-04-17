using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capture_ecran_MBE
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")] //
        static extern bool SetProcessDPIAware();                 // permet d'avoir toute la résolution disponible
        public Form1()
        {
            SetProcessDPIAware();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Screenshot_Click(object sender, EventArgs e)
        {
            pictureBox_Screenshot.Image = CaptureMBE.Capture(2);
        }
    }
}