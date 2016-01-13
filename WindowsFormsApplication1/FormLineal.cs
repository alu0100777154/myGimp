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
    public partial class FormLineal : Form
    {
        int[] hist, nhist;
        int[] y;
        int id, height, width, aux;
        FormPrincipal a;
        public System.Drawing.Bitmap a_Bitmap, m_Bitmap;
        bool crear;
        private void checkCrear_CheckedChanged(object sender, EventArgs e)
        {
            crear = !crear;
        }

        


        public FormLineal(System.Drawing.Bitmap m_Bitmap, int[] hist, int id, int height, int width)
        {
            InitializeComponent();
            y = new int[255];
            this.hist = hist;
            this.nhist = hist;
            this.id = id;
            this.height = height;
            this.width = width;
            this.m_Bitmap = m_Bitmap;
            crear = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            float x1 = Int32.Parse(xAxis1.Text);
            float x2 = Int32.Parse(xAxis2.Text);
            float y1 = Int32.Parse(yAxis1.Text);
            float y2 = Int32.Parse(yAxis2.Text);

            float dx = x2 - x1;
            //if (dx == 0)
            //    return float.NaN;
            float m = (y2 - y1) / dx;
            float b = y1 - (m * x1);

            for (int i = (int)x1; i < x2; i++) y[i] = (int)(m * i + b);


            eRecta.Text = "m " + m.ToString() + " b " + b.ToString();


            if (crear)
            {

                for (int i = 0; i < y.Count(); i++)
                {
                    if (y[i] < 0) y[i] = 0;
                    if (y[i] > 255) y[i] = 255;
                }

                a = (FormPrincipal)MdiParent;
                a_Bitmap = new Bitmap(m_Bitmap.Width, m_Bitmap.Height);

                for (int i = 0; i < m_Bitmap.Width; i++)
                {
                    for (int j = 0; j < m_Bitmap.Height; j++)
                    {
                        aux = m_Bitmap.GetPixel(i, j).B;
                        a_Bitmap.SetPixel(i, j, Color.FromArgb(255, y[aux], y[aux], y[aux]));
                        //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));

                    }
                }


                FormImagen subImagen = new FormImagen(a_Bitmap, a.lastid);
                a.Imagenes.Add(subImagen);
                a.Imagenes[a.lastid].MdiParent = this.MdiParent;
                a.Imagenes[a.lastid].Show();
                a.lastid++;


            }


        }

        private void yAxis2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}