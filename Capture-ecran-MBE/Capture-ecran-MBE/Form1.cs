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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Screenshot_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(System.Windows.Forms.SystemInformation.VirtualScreen.Width, System.Windows.Forms.SystemInformation.VirtualScreen.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            Graphics g = Graphics.FromImage(image);
            g.CopyFromScreen(rect.Top, rect.Left, 0, 0, rect.Size);
            pictureBox_Screenshot.Dock = DockStyle.Fill;
            pictureBox_Screenshot.Size = rect.Size;
            pictureBox_Screenshot.Image = image;
        }
    }
}