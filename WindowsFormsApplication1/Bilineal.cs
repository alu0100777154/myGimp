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
    public partial class Bilineal : Form
    {
        int[] hist, nhist;
        int[] y;
        int id;
        float A, B;
        bool percen;
        FormPrincipal a;
        public System.Drawing.Bitmap a_Bitmap, m_Bitmap;
        public Bilineal(System.Drawing.Bitmap m_Bitmap, int[] hist, int id)
        {
            percen = false;
            InitializeComponent();
            y = new int[255];
            this.hist = hist;
            this.nhist = hist;
            this.id = id;
            this.m_Bitmap = m_Bitmap;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            a = (FormPrincipal)MdiParent;
            float nalto, nancho;

            if (percen)
            {
                nalto = Int32.Parse(alto.Text);
                nalto = (float)nalto / 100 * m_Bitmap.Height;
                nalto = (int)nalto;
                nancho = Int32.Parse(ancho.Text);
                nancho = (float)nancho / 100 * m_Bitmap.Width;
                nancho = (int)nancho;
            }
            else
            {
                nalto = Int32.Parse(alto.Text);
                nancho = Int32.Parse(ancho.Text);
            }

            a_Bitmap = new Bitmap((int)nancho, (int)nalto);

            float a1 = ((float)nancho) / (m_Bitmap.Width - 1);
            float b1 = ((float)nalto) / (m_Bitmap.Height - 1);
            for (int i = 0; i < nancho; i++)
            {
                for (int j = 0; j < nalto; j++)
                {
                    float x = ((float)i) / a1;
                    float y = ((float)j) / b1;

                    int minX = (int)Math.Floor(x);
                    int minY = (int)Math.Floor(y);
                    int maxX = minX + 1;
                    int maxY = minY + 1;

                    double p = Math.Abs(x - minX);
                    double q = Math.Abs(y - minY);

                    Color pA = m_Bitmap.GetPixel(minX, maxY);
                    Color pB = m_Bitmap.GetPixel(maxX, maxY);
                    Color pC = m_Bitmap.GetPixel(minX, minY);
                    Color pD = m_Bitmap.GetPixel(maxX, minY);

                    int valor = (int)(((float)pC.R) + ((float)(pD.R - pC.R)) * p + ((float)(pA.R - pC.R)) * q + ((float)(pB.R + pC.R - pA.R - pD.R)) * p * q);


                    a_Bitmap.SetPixel(i, j, Color.FromArgb(255,valor,valor,valor));
                }
            }



            FormImagen subImagen = new FormImagen(a_Bitmap, a.lastid);
            a.Imagenes.Add(subImagen);
            a.Imagenes[a.lastid].MdiParent = this.MdiParent;
            a.Imagenes[a.lastid].Show();
            a.lastid++;


        }

        private void percent_CheckedChanged(object sender, EventArgs e)
        {
            percen = !percen;
        }
    }
}
