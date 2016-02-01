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
    public partial class FormGamma : Form
    {
        int[] hist, nhist;
        int[] y;
        int nVal;
        int id;
        FormPrincipal a;
        public System.Drawing.Bitmap a_Bitmap, m_Bitmap;
        public FormGamma(System.Drawing.Bitmap m_Bitmap, int[] hist, int id)
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

            float gamma_ = Int32.Parse(gamma.Text);
            gamma_ = gamma_/100;

            a = (FormPrincipal)MdiParent;
            a_Bitmap = new Bitmap(m_Bitmap.Width, m_Bitmap.Height);

            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {

                    nVal = (int)(Math.Pow((m_Bitmap.GetPixel(i,j).R / 255.0), gamma_) * 255);

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
