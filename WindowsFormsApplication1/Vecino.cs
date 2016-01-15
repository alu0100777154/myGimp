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
    public partial class Vecino : Form
    {
        int[] hist, nhist;
        int[] y;
        int id;
        bool percen;
        float A, B;
        FormPrincipal a;
        public System.Drawing.Bitmap a_Bitmap, m_Bitmap;
        public Vecino(System.Drawing.Bitmap m_Bitmap, int[] hist, int id)
        {
            InitializeComponent();
            y = new int[255];
            percen = false;
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
                nalto = (float)nalto/100 * m_Bitmap.Height;
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

/*            double x_ratio = m_Bitmap.Width / (double)nancho;
            double y_ratio = m_Bitmap.Height / (double)nalto;
            double px, py; */


            float a1 = ((float)nancho) / (m_Bitmap.Width - 1);
            float b1 = ((float)nalto) / (m_Bitmap.Height - 1);
            float x = 0, y = 0;

			for(int i = 0; i < nancho; i++){
		    	   for(int j = 0; j < nalto; j++){
                       x = (int)Math.Round((i) / a1);
                       y = (int)Math.Round((j) / b1);

                       a_Bitmap.SetPixel(i, j, m_Bitmap.GetPixel((int)x,(int)y));
		    		   //colorAux = vecino(newAncho,newAlto,i,j);

		    		   //outImage.setRGB(i,j,colorAux.getRGB());
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
