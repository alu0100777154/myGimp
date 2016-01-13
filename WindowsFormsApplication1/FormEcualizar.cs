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
    public partial class FormEcualizar : Form
    {
        int[] hist, nhist,ahist;
        int[] y;
        int id;
        float A, B;
        float vcontraste = 0, vbrillo = 0;
        FormPrincipal a;
        public System.Drawing.Bitmap a_Bitmap, m_Bitmap;
        public FormEcualizar(System.Drawing.Bitmap m_Bitmap, int[] hist, int[] ahist, int id)
        {
            InitializeComponent();
            y = new int[255];
            this.hist = hist;
            this.nhist = hist;
            this.ahist = ahist;
            this.id = id;
            this.m_Bitmap = m_Bitmap;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int tam = m_Bitmap.Width * m_Bitmap.Height;
            //            Imagenes[activeid].
            //            Imagenes[activeid].hist
            float c;
            int b;
            int aux;
            nhist = hist;


            for (int i = 0; i < 255; i++)
            {
                c = (float)(256 * ahist[i]);
                b = (int)(c / tam);
                nhist[i] = b - 1;
            }

            a = (FormPrincipal)MdiParent;
            a_Bitmap = new Bitmap(m_Bitmap.Width, m_Bitmap.Height);

            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    aux = m_Bitmap.GetPixel(i, j).B;
                    a_Bitmap.SetPixel(i, j, Color.FromArgb(255, nhist[aux], nhist[aux], nhist[aux]));
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
}
