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
    public partial class Form1 : Form
    {
        private System.Drawing.Bitmap m_Bitmap, a_Bitmap;
        // private double Zoom = 1.0;
        int[] a;
        int pixels = 0, aux = 0, auxi = 0;
        
        float contraste, brillo;
        Color[] copia;
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            a = new int[256];
            //            m_Bitmap = (Bitmap)Bitmap.FromFile(@"C:\Users\Guille\Desktop\303.jpg", false);
            //          pictureBox1.Image = m_Bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
        //    pictureBox1.Image = null;
            //this.Close();
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
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|Tiff files (*.tiff)|*.tiff";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                // Create a new bitmap.
                // m_Bitmap = (Bitmap)Bitmap.FromFile(@"C:\Users\Guille\Desktop\a.jpg", false);
                m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
                //            Color color = m_Bitmap.GetPixel(15, 15);
                //              this.AutoScroll = true;
                //              this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));

                //                int aux = 0;

                for (int i = 0; i < m_Bitmap.Width; i++)
                {
                    for (int j = 0; j < m_Bitmap.Height; j++)
                    {

                        a[m_Bitmap.GetPixel(i, j).B] += 1;
                        //m_Bitmap.SetPixel(i,j, /*Color.Red*/);
                        //color = m_Bitmap.GetPixel(i, j);
                        //m_Bitmap.SetPixel(i, j, Color.FromArgb(color.A, color.G, color.R, color.B));
                        //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));
                        pixels++;
                    }
                }
                for (int i = 0; i < a.Length; i++)
                {
                    brillo = brillo + a[i];
                }
                brillo /=a.Length;
                Form4 image = new Form4(m_Bitmap);

                image.MdiParent = this;
                image.Show();
                //MessageBox.Show(brillo.ToString());
                //               textRGB.Text = a.ToString();
                image.pictureBox1.Image = m_Bitmap;
                this.Invalidate();

            }
        }

        private void histogramaAcumulativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form3"] as Form3 != null)
            {
                //error
                MessageBox.Show("Error: Histogram is already open");
            }
            else
            {
                //open
                Form3 frm3 = new Form3(a);
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
                m_Bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   pictureBox1.Image = null;
        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form2"] as Form2 != null)
            {
                //error
                MessageBox.Show("Error: Histogram is already open");
            }
            else
            {
                //open
                Form2 frm2 = new Form2(a);
                frm2.MdiParent = this;
                frm2.Show();

            }
          
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {

                    Color gris = m_Bitmap.GetPixel(i, j);
                    int grey = (gris.R + gris.G + gris.B) / 3;
                    m_Bitmap.SetPixel(i, j, Color.FromArgb(gris.A, grey, grey, grey));
                    //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));
                    pixels = pixels + 1;
                }
            }

            //               textRGB.Text = a.ToString();
           /* Form4 image = new Form4(m_Bitmap);
            
            image.MdiParent = this;
            image.Show();*/
            //        pictureBox1.Image = m_Bitmap;
            this.Invalidate();
        }

        private void rOIToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            ROI = !ROI;
            if (ROI)
            {
                MessageBox.Show("Selecciona el primer pixel");
            }*/
        }
       
    }
}
