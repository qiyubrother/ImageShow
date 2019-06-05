using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

        }

        /// <summary>
        /// 水平百叶窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ImageShow imageShow = new ImageShow();
            var bmp = new Bitmap(Properties.Resources.人体解刨图);
            imageShow.Effect_BaiYeH(Properties.Resources.人体解刨图, bmp, pictureBox1);
        }
        /// <summary>
        /// 垂直百叶窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ImageShow imageShow = new ImageShow();
            var bmp = new Bitmap(Properties.Resources.人体解刨图);
            imageShow.Effect_BaiYeV(Properties.Resources.人体解刨图, bmp, pictureBox1);
        }
        /// <summary>
        /// 从左向右
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            ImageShow imageShow = new ImageShow();
            var bmp = new Bitmap(Properties.Resources.小图.Width, Properties.Resources.小图.Height);
            imageShow.Effect_L2R(bmp, Properties.Resources.小图, pictureBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImageShow imageShow = new ImageShow();
            var bmp = new Bitmap(Properties.Resources.小图.Width, Properties.Resources.小图.Height);
            imageShow.Effect_R2L(bmp, Properties.Resources.小图, pictureBox1);
        }
        /// <summary>
        /// 从上向下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            ImageShow imageShow = new ImageShow();
            var bmp = new Bitmap(Properties.Resources.小图.Width, Properties.Resources.小图.Height);
            imageShow.Effect_U2D(bmp, Properties.Resources.小图, pictureBox1);
        }
        /// <summary>
        /// 从下向上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            ImageShow imageShow = new ImageShow();
            var bmp = new Bitmap(Properties.Resources.特大尺寸图.Width, Properties.Resources.特大尺寸图.Height);
            imageShow.Effect_D2U(bmp, Properties.Resources.特大尺寸图, pictureBox1);
        }
    }
}
