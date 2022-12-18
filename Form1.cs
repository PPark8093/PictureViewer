using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //파일선택 팝업창을 보여준뒤,
            //사용자가 이미지를 고르고 확인을 누르면,
            //사용자가 고른 이미지를 보여준다.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //(프로그램에서 표시되는)이미지를 없앤다
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // 색선택창을 보여준뒤,
            //사용자가 확인을 누르면,
            //골랐던 색을 picutreBox1의 배경색으로 변경한다
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //닫는다.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
