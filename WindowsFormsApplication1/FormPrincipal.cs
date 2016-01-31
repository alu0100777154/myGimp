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
    public partial class FormPrincipal : Form
    {
        public int lastid = 0, activeid;
        // private double Zoom = 1.0;
        public List<FormImagen> Imagenes;
        int[] a;
        //   int pixels = 0, aux = 0, auxi = 0;
        //Color[] copia;
        public FormPrincipal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            a = new int[256];
            Imagenes = new List<FormImagen>();

            FormImagen image = new FormImagen(@"C:\Users\Guille\Desktop\a.jpg", lastid);
            Imagenes.Add(image);
            Imagenes[lastid].MdiParent = this;
            Imagenes[lastid].Show();
            lastid++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "myGimp";
            this.IsMdiContainer = true;
        }

        private void cargarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            /* if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 pictureBox1.Load(openFileDialog1.FileName);
             }*/
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "*.*|*.*|Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|Tiff files (*.tiff)|*.tiff";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                FormImagen image = new FormImagen(openFileDialog.FileName, lastid);
                Imagenes.Add(image);
                Imagenes[lastid].MdiParent = this;
                Imagenes[lastid].Show();
                lastid++;
                this.Invalidate();
            }
        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Histograma " + activeid] as FormHistograma != null)
            {
                //error
                MessageBox.Show("Error: Histogram is already open");
            }
            else
            {
                //open
                FormHistograma frm2 = new FormHistograma(Imagenes[activeid].hist, activeid, Imagenes[activeid].brillo, Imagenes[activeid].contraste, Imagenes[activeid].entropia, Imagenes[activeid].min, Imagenes[activeid].max);
                frm2.MdiParent = this;
                frm2.Show();

            }

        }

        private void histogramaAcumulativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HistogramaAbs " + activeid] as FormHistogramaAbs != null)
            {
                //error
                MessageBox.Show("Error: Histogram is already open");
            }
            else
            {
                //open
                FormHistogramaAbs frm3 = new FormHistogramaAbs(Imagenes[activeid].hist, activeid);
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|Tiff files (*.tiff)|*.tiff";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
               //  m_Bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //image.pictureBox1.Image = vacia;
            //FormImagen image = new FormImagen(vacia);
        }


        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap trans = new Bitmap(Imagenes.Find(x => x.id == activeid).m_Bitmap.Width, Imagenes.Find(x => x.id == activeid).m_Bitmap.Height);
            Bitmap m_Bitmap = Imagenes.Find(x => x.id == activeid).m_Bitmap;
            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    Color gris = m_Bitmap.GetPixel(i, j);
                    int grey = (gris.R + gris.G + gris.B) / 3;
                    trans.SetPixel(i, j, Color.FromArgb(gris.A, grey, grey, grey));
                    //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));
                    //pixels = pixels + 1;
                }
            }
            FormImagen image = new FormImagen(trans, lastid);
            Imagenes.Add(image);
            Imagenes[lastid].MdiParent = this;
            Imagenes[lastid].Show();
            lastid++;
            //        pictureBox1.Image = m_Bitmap;
            this.Invalidate();
        }

        private void rOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagenes[activeid].ROI = !Imagenes[activeid].ROI;

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagenes[activeid].select = !Imagenes[activeid].select;
        }

        private void linealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLineal frm = new FormLineal(Imagenes[activeid].m_Bitmap, Imagenes[activeid].hist, activeid, Imagenes[activeid].Height, Imagenes[activeid].Width);
            frm.MdiParent = this;
            frm.Show();
        }

        private void brilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBrillo frm = new FormBrillo(Imagenes[activeid].m_Bitmap, Imagenes[activeid].hist, activeid);
            frm.MdiParent = this;
            frm.Show();
        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGamma frm = new FormGamma(Imagenes[activeid].m_Bitmap, Imagenes[activeid].hist, activeid);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ecualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEcualizar frm = new FormEcualizar(Imagenes[activeid].m_Bitmap, Imagenes[activeid].hist, Imagenes[activeid].ahist, activeid);
            frm.MdiParent = this;
            frm.Show();

        }

        private void espejoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap trans = new Bitmap(Imagenes.Find(x => x.id == activeid).m_Bitmap.Width, Imagenes.Find(x => x.id == activeid).m_Bitmap.Height);
            Bitmap m_Bitmap = Imagenes.Find(x => x.id == activeid).m_Bitmap;
            int height = m_Bitmap.Height - 1;
            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    Color aux = m_Bitmap.GetPixel(i, j);
                    trans.SetPixel(i, height - j, aux);
                }
            }
            FormImagen image = new FormImagen(trans, lastid);
            Imagenes.Add(image);
            Imagenes[lastid].MdiParent = this;
            Imagenes[lastid].Show();
            lastid++;
            this.Invalidate();
        }

        private void espejoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap trans = new Bitmap(Imagenes.Find(x => x.id == activeid).m_Bitmap.Width, Imagenes.Find(x => x.id == activeid).m_Bitmap.Height);
            Bitmap m_Bitmap = Imagenes.Find(x => x.id == activeid).m_Bitmap;
            int width = m_Bitmap.Width - 1;
            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    Color aux = m_Bitmap.GetPixel(i, j);
                    trans.SetPixel(width - i, j, aux);
                }
            }
            FormImagen image = new FormImagen(trans, lastid);
            Imagenes.Add(image);
            Imagenes[lastid].MdiParent = this;
            Imagenes[lastid].Show();
            lastid++;
            this.Invalidate();
        }

        private void traspuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap trans = new Bitmap(Imagenes.Find(x => x.id == activeid).m_Bitmap.Width, Imagenes.Find(x => x.id == activeid).m_Bitmap.Height);
            Bitmap m_Bitmap = Imagenes.Find(x => x.id == activeid).m_Bitmap;

            if (m_Bitmap.Height != m_Bitmap.Width)
            {
                trans = new Bitmap(Imagenes.Find(x => x.id == activeid).m_Bitmap.Height, Imagenes.Find(x => x.id == activeid).m_Bitmap.Width);

                //trans.Height = m_Bitmap.Width;
                //trans.Width = m_Bitmap.Height;
            }

            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    Color aux = m_Bitmap.GetPixel(i, j);
                    trans.SetPixel(j, i, aux);
                }
            }
            FormImagen image = new FormImagen(trans, lastid);
            Imagenes.Add(image);
            Imagenes[lastid].MdiParent = this;
            Imagenes[lastid].Show();
            lastid++;
            this.Invalidate();
        }

        private void rotacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap trans = new Bitmap(Imagenes.Find(x => x.id == activeid).m_Bitmap.Height, Imagenes.Find(x => x.id == activeid).m_Bitmap.Width)
                
                ;
            Bitmap m_Bitmap = Imagenes.Find(x => x.id == activeid).m_Bitmap;


                for (int i = 0; i < m_Bitmap.Width; i++)
                {
                    for (int j = 0; j < m_Bitmap.Height; j++)
                    {
                        Color aux = m_Bitmap.GetPixel(i, j);
                       trans.SetPixel(m_Bitmap.Height-j-1, i, aux);
                }
            }
            FormImagen image = new FormImagen(trans, lastid);
            Imagenes.Add(image);
            Imagenes[lastid].MdiParent = this;
            Imagenes[lastid].Show();
            lastid++;
            this.Invalidate();       
        
    }

        private void rotacion180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap trans = new Bitmap(Imagenes.Find(x => x.id == activeid).m_Bitmap.Width, Imagenes.Find(x => x.id == activeid).m_Bitmap.Height);
            Bitmap m_Bitmap = Imagenes.Find(x => x.id == activeid).m_Bitmap;


            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    Color aux = m_Bitmap.GetPixel(i, j);
                    trans.SetPixel(m_Bitmap.Width - i - 1, m_Bitmap.Height - j - 1, aux);
                }
            }
            FormImagen image = new FormImagen(trans, lastid);
            Imagenes.Add(image);
            Imagenes[lastid].MdiParent = this;
            Imagenes[lastid].Show();
            lastid++;
            this.Invalidate();
        }

        private void rotacion270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap trans = new Bitmap(Imagenes.Find(x => x.id == activeid).m_Bitmap.Height, Imagenes.Find(x => x.id == activeid).m_Bitmap.Width);
            Bitmap m_Bitmap = Imagenes.Find(x => x.id == activeid).m_Bitmap;


            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    Color aux = m_Bitmap.GetPixel(i, j);
                    trans.SetPixel(j, m_Bitmap.Width - i - 1, aux);
                }
            }
            FormImagen image = new FormImagen(trans, lastid);
            Imagenes.Add(image);
            Imagenes[lastid].MdiParent = this;
            Imagenes[lastid].Show();
            lastid++;
            this.Invalidate();
        }

       

        private void vecinoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Vecino frm = new Vecino(Imagenes[activeid].m_Bitmap, Imagenes[activeid].hist, activeid);
            frm.MdiParent = this;
            frm.Show();
        }

        private void bilinealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilineal frm = new Bilineal(Imagenes[activeid].m_Bitmap, Imagenes[activeid].hist, activeid);
            frm.MdiParent = this;
            frm.Show();
        }


    }
}