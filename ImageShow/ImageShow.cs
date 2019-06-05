using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageShow
{
    class ImageShow
    {

        //水平百叶窗
        public void Effect_BaiYeH(Bitmap obmp, Bitmap bmp, PictureBox pic)
        {
            int step = 30;
            try
            {
                Bitmap bmp1 = (Bitmap)bmp.Clone();
                int height = bmp1.Height / step;
                int width = bmp1.Width;
                Graphics g = Graphics.FromImage(obmp);
                Point[] MyPoint = new Point[step];
                for (int y = 0; y < step; y++)
                {
                    MyPoint[y].X = 0;
                    MyPoint[y].Y = y * height;
                }
                Bitmap bitmap = new Bitmap(bmp.Width, bmp.Height);
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < step; j++)
                    {
                        for (int k = 0; k < width; k++)
                        {
                            bitmap.SetPixel(MyPoint[j].X + k, MyPoint[j].Y + i, bmp.GetPixel(MyPoint[j].X + k, MyPoint[j].Y + i));
                        }
                    }
                    pic.Refresh();
                    pic.Image = bitmap;

                    System.Threading.Thread.Sleep(20);
                }
                g.Dispose();
                bmp1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }

        }

        //垂直百叶窗
        public void Effect_BaiYeV(Bitmap obmp, Bitmap bmp, PictureBox pic)
        {
            int step = 50;
            try
            {
                Bitmap bmp1 = (Bitmap)bmp.Clone();
                int dw = bmp1.Width / step;
                int dh = bmp1.Height;
                Graphics g = Graphics.FromImage(obmp);
                Point[] MyPoint = new Point[step];
                for (int x = 0; x < step; x++)
                {
                    MyPoint[x].Y = 0;
                    MyPoint[x].X = x * dw;
                }
                Bitmap bitmap = new Bitmap(bmp1.Width, bmp1.Height);
                for (int i = 0; i < dw; i++)
                {
                    for (int j = 0; j < step; j++)
                    {
                        for (int k = 0; k < dh; k++)
                        {
                            bitmap.SetPixel(MyPoint[j].X + i, MyPoint[j].Y + k, bmp1.GetPixel(MyPoint[j].X + i, MyPoint[j].Y + k));
                        }
                    }
                    pic.Refresh();
                    pic.Image = bitmap;

                    System.Threading.Thread.Sleep(20);
                }
                g.Dispose();
                bmp1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        //从上向下
        public void Effect_U2D(Bitmap obmp, Bitmap bmp, PictureBox pic)
        {
            try
            {
                int width = bmp.Width;
                int height = bmp.Height;

                Graphics g = pic.CreateGraphics();
                g.DrawImage(obmp, 0, 0, width, height);
                for (int y = 1; y <= height; y += 10)
                {
                    Bitmap bitmap = bmp.Clone(new Rectangle(0, 0, width, y), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    g.DrawImage(bitmap, 0, 0);
                    System.Threading.Thread.Sleep(10);
                }
                g.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
        //从下向上
        public void Effect_D2U(Bitmap obmp, Bitmap bmp, PictureBox pic)
        {
            try
            {
                int width = bmp.Width;
                int height = bmp.Height;

                Graphics g = pic.CreateGraphics();
                g.DrawImage(obmp, 0, 0, width, height);

                for (int y = 1; y <= height; y += 10)
                {
                    Bitmap bitmap = bmp.Clone(new Rectangle(0, height - y, width, y), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    g.DrawImage(bitmap, 0, height - y);
                    System.Threading.Thread.Sleep(10);
                }
                g.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        //从左向右
        public void Effect_L2R(Bitmap obmp, Bitmap bmp, PictureBox pic)
        {
            try
            {
                int width = bmp.Width;
                int height = bmp.Height;
                Graphics g = pic.CreateGraphics();
                g.DrawImage(obmp, 0, 0, width, height);
                for (int x = 1; x <= width; x += 10)
                {
                    Bitmap bitmap = bmp.Clone(new Rectangle(0, 0, x, height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    g.DrawImage(bitmap, 0, 0);
                    System.Threading.Thread.Sleep(10);
                }
                g.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        //从右向左
        public void Effect_R2L(Bitmap obmp, Bitmap bmp, PictureBox pic)
        {
            try
            {
                int width = bmp.Width;
                int height = bmp.Height;
                Graphics g = pic.CreateGraphics();
                g.DrawImage(obmp, 0, 0, width, height);
                for (int x = 1; x <= width; x += 10)
                {
                    Bitmap bitmap = bmp.Clone(new Rectangle(width - x, 0, x, height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    g.DrawImage(bitmap, width - x, 0);
                    System.Threading.Thread.Sleep(10);
                }
                g.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
    }
}
