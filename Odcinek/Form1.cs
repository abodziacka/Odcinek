using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odcinek
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            x0_text.Visible = false;
            y0_text.Visible = false;
            x1_text.Visible = false;
            y1_text.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            panel1.Visible = true;
            picture.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            clear_btn.Visible = false;





        }
        void DrawPixel(int x, int y, Color color)
        {

            bmp.SetPixel(x, y, color);
            picture.Image = bmp;
        }

        public void Bresenham(int x0, int y0, int x1, int y1)
        {
            Color color = Color.DarkRed;

            int dx, dy, kx, ky;
            float e;
            if (x0 <= x1)
            {
                kx = 1;
            }
            else
            {
                kx = -1;
            }

            if (y0 <= y1)
            {
                ky = 1;
            }
            else
            {
                ky = -1;
            }

            dx = Math.Abs(x1 - x0);
            dy = Math.Abs(y1 - y0);

            DrawPixel(x0, y0, color);

            if (dx < dy)
            {
                e = dy / 2;
                for (int i = 0; i < dy; i++)
                {
                    y0 = y0 + ky;
                    e = e - dx;
                    if (e >= 0)
                    {
                        DrawPixel(x0, y0, color);

                    }
                    else
                    {
                        x0 = x0 + kx;
                        e = e + dy;
                        DrawPixel(x0, y0, color);


                    }
                }
            }
            else
            {
                e = dx / 2;
                for (int i = 0; i < dx; i++)
                {
                    x0 = x0 + kx;
                    e = e - dy;
                    if (e >= 0)
                    {
                        DrawPixel(x0, y0, color);


                    }
                    else
                    {
                        y0 = y0 + ky;
                        e = e + dx;
                        DrawPixel(x0, y0, color);


                    }
                }
            }

        }

        public void Przyrost(int x0, int y0, int xk, int yk)
        {
            Color color = Color.MidnightBlue;

            if (x0 > xk)
            {
                int xc = x0;
                x0 = xk;
                xk = xc;

                int yc = y0;
                y0 = yk;
                yk = yc;
            }
            float dx = xk - x0;
            float dy = yk - y0;
            float m = dy / dx;

            if (Math.Abs(m) > 1)
            {
                if (y0 > yk)
                {
                    int xc = x0;
                    x0 = xk;
                    xk = xc;

                    int yc = y0;
                    y0 = yk;
                    yk = yc;
                }
                dx = xk - x0;
                dy = yk - y0;
                m = dx / dy;
                float x = x0;
                for (int y = y0; y <= yk; y += 1)
                {
                    DrawPixel((int)Math.Floor(x + 0.5), y, color);
                    x += m;
                }
            }
            else
            {
                float y = y0;
                for (int x = x0; x <= xk; x += 1)
                {
                    DrawPixel(x, (int)Math.Floor(y + 0.5), color);
                    y += m;
                }
            }




        }

        private void x0_text_TextChanged(object sender, EventArgs e)
        {

            int x0;
            bool success = Int32.TryParse(x0_text.Text, out x0);
            if (x0_text.Text != "")
            {
                if (!success)
                {
                    MessageBox.Show("Podaj dodatnią liczbę całkowitą z przedziału (0,960).");
                    x0_text.Text = "";


                }
                else
                {
                    if (x0 > 960)
                    {
                        MessageBox.Show("Podaj dodatnią liczbę całkowitą z przedziału (0,960).");
                        x0_text.Text = "";


                    }
                }
            }


        }

        private void y0_text_TextChanged(object sender, EventArgs e)
        {
            int y0;
            bool success = Int32.TryParse(y0_text.Text, out y0);
            if (y0_text.Text != "")
            {
                if (!success)
                {
                    MessageBox.Show("Podaj dodatnią liczbę całkowitą z przedziału (0,440).");
                    y0_text.Text = "";


                }
                else
                {
                    if (y0 > 440)
                    {
                        MessageBox.Show("Podaj dodatnią liczbę całkowitą z przedziału (0,440).");
                        y0_text.Text = "";


                    }
                }
            }
        }
        private void x1_text_TextChanged(object sender, EventArgs e)
        {
            int x1;
            bool success = Int32.TryParse(x1_text.Text, out x1);
            if (x1_text.Text != "")
            {
                if (!success)
                {
                    MessageBox.Show("Podaj dodatnią liczbę całkowitą z przedziału (0,960).");
                    x1_text.Text = "";


                }
                else
                {
                    if (x1 > 960)
                    {
                        MessageBox.Show("Podaj dodatnią liczbę całkowitą z przedziału (0,960).");
                        x1_text.Text = "";


                    }
                }

            }
        }

        private void y1_text_TextChanged(object sender, EventArgs e)
        {
            int y1;
            bool success = Int32.TryParse(y1_text.Text, out y1);
            if (y1_text.Text != "")
            {
                if (!success)
                {
                    MessageBox.Show("Podaj dodatnią liczbę całkowitą z przedziału (0,440).");
                    y1_text.Text = "";


                }
                else
                {
                    if (y1 > 440)
                    {
                        MessageBox.Show("Podaj dodatnią liczbę całkowitą z przedziału (0,440).");
                        y1_text.Text = "";

                    }
                }

            }
        }

        private void bres_btn_Click(object sender, EventArgs e)
        {

            if (x0_text.Text != "" && y0_text.Text != "" && x1_text.Text != "" && y1_text.Text != "")
            {

                int x0 = Int32.Parse(x0_text.Text);
                int y0 = Int32.Parse(y0_text.Text);
                int x1 = Int32.Parse(x1_text.Text);
                int y1 = Int32.Parse(y1_text.Text);

                Color color = Color.Black;


                if ((x0 >= 0 && x0 < 961) && (x1 >= 0 && x1 < 961) && (y0 >= 0 && y0 < 441) && (y1 >= 0 && y1 < 441))
                {
                    Bresenham(x0, y0, x1, y1);
                    x0_text.Text = "";
                    x1_text.Text = "";
                    y0_text.Text = "";
                    y1_text.Text = "";
                    ile = 0;


                }
                else
                {
                    MessageBox.Show("Złe wartości współrzędnych! 0<=x<961; 0<=y<441");

                }


            }
            else
            {
                MessageBox.Show("Nie podano 2 punktów!");
            }

        }
        private void przy_btn_Click(object sender, EventArgs e)
        {
            if (x0_text.Text != "" && y0_text.Text != "" && x1_text.Text != "" && y1_text.Text != "")
            {
                int x0 = Int32.Parse(x0_text.Text);
                int y0 = Int32.Parse(y0_text.Text);
                int x1 = Int32.Parse(x1_text.Text);
                int y1 = Int32.Parse(y1_text.Text);

                Color color = Color.Black;
                if ((x0 >= 0 && x0 < 961) && (x1 >= 0 && x1 < 961) && (y0 >= 0 && y0 < 441) && (y1 >= 0 && y1 < 441))
                {
                    Przyrost(x0, y0, x1, y1);
                    x0_text.Text = "";
                    x1_text.Text = "";
                    y0_text.Text = "";
                    y1_text.Text = "";
                    ile = 0;

                }
                else
                {
                    MessageBox.Show("Złe wartości współrzędnych! 0<=x<961; 0<=y<441");

                }
            }
            else
            {
                MessageBox.Show("Nie podano 2 punktów!");
            }
        }



        private void wybor1_Click(object sender, EventArgs e)
        {

            x0_text.Visible = true;
            x0_text.ReadOnly = false;

            y0_text.Visible = true;
            y0_text.ReadOnly = false;

            x1_text.Visible = true;
            x1_text.ReadOnly = false;

            y1_text.Visible = true;
            y1_text.ReadOnly = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;

            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            panel1.Visible = true;
            picture.Visible = true;
            clear_btn.Visible = true;



        }

        private void wybor2_Click(object sender, EventArgs e)
        {

            x0_text.Visible = true;
            x0_text.ReadOnly = true;
            y0_text.Visible = true;
            y0_text.ReadOnly = true;

            x1_text.Visible = true;
            x1_text.ReadOnly = true;

            y1_text.Visible = true;
            y1_text.ReadOnly = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            panel1.Visible = true;
            picture.Visible = true;
            clear_btn.Visible = true;


        }
        bool haveFirst = false;
        int ile = 0;
        private void picture_Click(object sender, EventArgs e)
        {
            MouseEventArgs eM = (MouseEventArgs)e;


            if (!haveFirst)
            {
                x0_text.Text = eM.X.ToString();
                y0_text.Text = eM.Y.ToString();
                haveFirst = true;
                ile++;
            }
            else
            {
                x1_text.Text = eM.X.ToString();
                y1_text.Text = eM.Y.ToString();
                haveFirst = false;
                ile++;


            }
            if (ile > 2)
            {
                MessageBox.Show("Muszą być podane tylko 2 punkty!");
                x0_text.Text = "";
                x1_text.Text = "";
                y0_text.Text = "";
                y1_text.Text = "";
                ile = 0;
                haveFirst = false;

            }


        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            picture.Image = null;
            haveFirst = false;
            ile = 0;

            x0_text.Text = "";
            x1_text.Text = "";
            y0_text.Text = "";
            y1_text.Text = "";
            picture.Invalidate();
            Form1_Load(sender, e);
        }
    }
}
