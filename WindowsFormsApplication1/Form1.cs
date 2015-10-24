using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private System.Drawing.Bitmap m_Bitmap;
        private double Zoom = 1.0;
        int[] a;
        public Form1()
        {
            InitializeComponent();
            a = new int[256];
            //            m_Bitmap = (Bitmap)Bitmap.FromFile(@"C:\Users\Guille\Desktop\303.jpg", false);
            //          pictureBox1.Image = m_Bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
            //this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }

        private void cargarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
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
                m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
                Color color = m_Bitmap.GetPixel(15, 15);
                this.AutoScroll = true;
                this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));

//                int aux = 0;

                for (int i = 0; i < m_Bitmap.Width; i++)
                {
                    for (int j = 0; j < m_Bitmap.Height; j++)
                    {

                        a[m_Bitmap.GetPixel(i, j).B]+=1;
                        //m_Bitmap.SetPixel(i,j, /*Color.Red*/);
                        //color = m_Bitmap.GetPixel(i, j);
                        //m_Bitmap.SetPixel(i, j, Color.FromArgb(color.A, color.G, color.R, color.B));
                        //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));
                        //aux++;
                    }
                }

 //               textRGB.Text = a.ToString();

                pictureBox1.Image = m_Bitmap;
                this.Invalidate();

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
            pictureBox1.Image = null;
        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2(a);
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();

//            for (int i = 0; i < 150; i++)
  //            Form2.chart1.Series[0].Points.AddXY(i, a[i]);

        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {

                    Color gris = m_Bitmap.GetPixel(i, j);
                    int grey = (gris.R + gris.G + gris.B)/3;
                    m_Bitmap.SetPixel(i, j, Color.FromArgb(gris.A, grey, grey, grey));
                    //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));
                    //aux++;
                }
            }

            //               textRGB.Text = a.ToString();

            pictureBox1.Image = m_Bitmap;
            this.Invalidate();
        }
    }
}
