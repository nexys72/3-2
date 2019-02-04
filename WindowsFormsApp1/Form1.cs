using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenDlg_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (OpenDlg.ShowDialog() == DialogResult.OK)
                Img.Image = new Bitmap(OpenDlg.FileName);
        }

        private void SizeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeCb.Checked)
                Img.SizeMode = PictureBoxSizeMode.Zoom;
            else Img.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
