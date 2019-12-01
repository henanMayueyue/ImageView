using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageView
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Image Files (*.JPG; *.BMP; *.PNG; *.GIF)|*.JPG; *.BMP; *.PNG; *.GIF";
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Некорректный файл");
                }
            }
        }
    }
}
