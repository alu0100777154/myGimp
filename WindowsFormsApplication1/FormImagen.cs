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
    public partial class FormImagen : Form
    {
        public int id;
        public bool ROI = false, select=false;
        bool segundo = false;
        int cpx, cpy, cx, cy, rectx, recty;
        public System.Drawing.Bitmap m_Bitmap, a_Bitmap;
        Color[] copia;
        int pixels = 0;
        public int[] hist;


        /*
         *
         * for (int i = 0; i < a.Length; i++)
                {
                    brillo = brillo + a[i];
                }
                brillo /=a.Length;
         * 
         */


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (select)
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
                    int aux = 0, auxi = 0;
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
                    FormPrincipal a = (FormPrincipal)MdiParent;
                    FormImagen subImagen = new FormImagen(a_Bitmap, a.lastid);
                    a.Imagenes.Add(subImagen);
                    a.Imagenes[a.lastid].Show();
                    a.lastid++;


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
        }

        public FormImagen(string FileName, int id)
        {
            this.id = id;
            InitializeComponent();
            m_Bitmap = (Bitmap)Bitmap.FromFile( FileName, false);
            hist = new int[256];
            pictureBox1.Image = m_Bitmap;

            this.Height = pictureBox1.Image.Height + 15;
            this.Width = pictureBox1.Image.Width + 15;
            
            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                    {

                        hist[m_Bitmap.GetPixel(i, j).B] += 1;
                        //m_Bitmap.SetPixel(i,j, /*Color.Red*/);
                        //color = m_Bitmap.GetPixel(i, j);
                        //m_Bitmap.SetPixel(i, j, Color.FromArgb(color.A, color.G, color.R, color.B));
                        //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));
                     pixels++;
                    }
                }
            
        }

        public FormImagen(Bitmap bitmap, int id)
        {
            this.id = id;
            InitializeComponent();
            m_Bitmap = bitmap;
            hist = new int[256];
            pictureBox1.Image = m_Bitmap;
            this.Height = pictureBox1.Image.Height + 15;
            this.Width = pictureBox1.Image.Width + 15;
        }

        private void FormImagen_Activated(object sender, EventArgs e)
        {
            FormPrincipal a = (FormPrincipal)MdiParent;
            a.activeid = id;
            this.Text = id.ToString();

        }
    }
}