using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGimp
{
    public partial class Form4 : Form
    {
        bool ROI = false;
        bool segundo = false;
        int cpx, cpy, cx, cy, rectx, recty;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            if (!ROI)
            {
                Color valor = m_Bitmap.GetPixel(coordinates.X, coordinates.Y);
                MessageBox.Show(coordinates + " Valor de gris " + valor.G);
            }

            if (ROI)
            {
                if (segundo)
                {
                    copia = new Color[pixels];
                    cx = coordinates.X;
                    cy = coordinates.Y;
                    rectx = Math.Abs(cx - cpx);
                    recty = Math.Abs(cy - cpy);
                    //Size tam = new Size(Math.Abs(cx-cpx),Math.Abs(cy-cpy));
                    a_Bitmap = new Bitmap(rectx, recty);
                    for (int i = cpx; i < cx; i++)
                    {
                        for (int j = cpy; j < cy; j++)
                        {
                            copia[aux] = m_Bitmap.GetPixel(i, j);
                            aux++;
                            //                            a_Bitmap.SetPixel(i,j,copia);
                        }
                    }

                    for (int i = 0; i < rectx; i++)
                    {
                        for (int j = 0; j < recty; j++)
                        {
                            a_Bitmap.SetPixel(i, j, copia[auxi]);
                            auxi++;
                        }
                    }
                    //          pictureBox1.Image = a_Bitmap;
                    segundo = !segundo;
                }
                else
                {
                    cpx = coordinates.X;
                    cpy = coordinates.Y;
                    segundo = !segundo;
                    MessageBox.Show("Selecciona el segundo pixel");
                }

            }
        }

        public Form4(Bitmap a)
        {
            InitializeComponent();
           // pictureBox1.Image = a;
        }
    }
}
