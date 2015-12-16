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
    public partial class FormBrillo : Form
    {
        int[] hist, nhist;
        int[] y;
        int id;
        float A, B;
        float vcontraste = 0, vbrillo = 0;
        FormPrincipal a;
        public System.Drawing.Bitmap a_Bitmap, m_Bitmap;
        public FormBrillo(System.Drawing.Bitmap m_Bitmap, int[] hist, int id)
        {
            InitializeComponent();
            y = new int[255];
            this.hist = hist;
            this.nhist = hist;
            this.id = id;
            this.m_Bitmap = m_Bitmap;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int tam = m_Bitmap.Width * m_Bitmap.Height;

            for (int i = 0; i < hist.Count(); i++)
                vbrillo += hist[i] * i;

            vbrillo /= tam;

            for (int i = 0; i < hist.Count(); i++)
                vcontraste += hist[i] * (float)Math.Pow(i - vbrillo, 2);

            vcontraste = (float)Math.Sqrt(vcontraste / tam);

            float nbrillo = Int32.Parse(brillo.Text);
            float ncontraste = Int32.Parse(contraste.Text);
            int nVal;

            A = ncontraste / vcontraste;
            B = nbrillo - (A * vbrillo);

            a = (FormPrincipal)MdiParent;
            a_Bitmap = new Bitmap(m_Bitmap.Width, m_Bitmap.Height);

            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    //int nVal = (int)(m_Bitmap.GetPixel(i, j).B + (int)nbrillo);

                    if (A != 0) nVal = (m_Bitmap.GetPixel(i, j).B * (int)A + (int)B);
                    else nVal= m_Bitmap.GetPixel(i, j).B + (int)B;
                    //red*A+B;
                    if (nVal < 0) nVal = 0;
                    if (nVal > 255) nVal = 255;

                    a_Bitmap.SetPixel(i, j, Color.FromArgb(255, nVal, nVal, nVal));
                }
            }
            FormImagen subImagen = new FormImagen(a_Bitmap, a.lastid);
            a.Imagenes.Add(subImagen);
            a.Imagenes[a.lastid].MdiParent = this.MdiParent;
            a.Imagenes[a.lastid].Show();
            a.lastid++;
        }
    }
}
