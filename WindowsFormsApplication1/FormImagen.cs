﻿using System;
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
        public int id, nVal;
        public bool ROI = false, select = false;
        bool segundo = false;
        public int cpx, cpy, cx, cy, rectx, recty, min, max;
        public System.Drawing.Bitmap m_Bitmap, a_Bitmap;


        public FormImagen(string FileName, int id)
        {
            this.id = id;
            int aux = 0;
            InitializeComponent();
            valores = new List<int>();
            m_Bitmap = (Bitmap)Bitmap.FromFile(FileName, false);
            hist = new int[256];
            ahist = new int[256];
            int tam = m_Bitmap.Width * m_Bitmap.Height;
            pictureBox1.Image = m_Bitmap;
            this.Height = pictureBox1.Image.Height + 40;
            this.Width = pictureBox1.Image.Width + 20;
            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    hist[m_Bitmap.GetPixel(i, j).B] += 1;
                    //m_Bitmap.SetPixel(i,j, /*Color.Red*/);
                    //color = m_Bitmap.GetPixel(i, j);
                    //m_Bitmap.SetPixel(i, j, Color.FromArgb(color.A, color.G, color.R, color.B));
                    //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));
                    valores.Add(m_Bitmap.GetPixel(i, j).B);
                }
            }

            for (int i = 0; i < hist.Count(); i++)
            {
                ahist[i] = hist[i] + aux;
                aux = aux + hist[i];
            }

            for (int i = 0; i < hist.Count(); i++) //103
                brillo += hist[i] * i;

            brillo /= tam;

            for (int i = 0; i < hist.Count(); i++)
                contraste += hist[i] * (float)Math.Pow(i - brillo, 2);

            contraste = (float)Math.Sqrt(contraste / tam);


            float prob = 0, log2P = 0;
            for (int i = 0; i < 256; i++)
            {
                prob = ((float)hist[i]) / (tam);
                if (prob != 0)
                    log2P = (float)(Math.Log(prob) / Math.Log(2));
                else
                    log2P = 0;
                entropia = entropia + (prob * log2P);
            }
            entropia = entropia * -1;

            int n = 0;
            do
            {
                n++;
                min = n;
            } while (hist[n] == 0);

            n = 255;
            do
            {
                max = n;
                n--;
            } while (hist[n] == 0);
        }

        public FormImagen(Bitmap bitmap, int id)
        {
            this.id = id;
            InitializeComponent();
            int aux = 0;
            m_Bitmap = bitmap;
            hist = new int[256];
            ahist = new int[256];
            pictureBox1.Image = m_Bitmap;
            this.Height = pictureBox1.Image.Height + 40;
            this.Width = pictureBox1.Image.Width + 20;
            valores = new List<int>();
            int tam = m_Bitmap.Width * m_Bitmap.Height;
            for (int i = 0; i < m_Bitmap.Width; i++)
            {
                for (int j = 0; j < m_Bitmap.Height; j++)
                {
                    hist[m_Bitmap.GetPixel(i, j).B] += 1;
                    //m_Bitmap.SetPixel(i,j, /*Color.Red*/);
                    //color = m_Bitmap.GetPixel(i, j);
                    //m_Bitmap.SetPixel(i, j, Color.FromArgb(color.A, color.G, color.R, color.B));
                    //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));
                    valores.Add(m_Bitmap.GetPixel(i, j).B);
                }
            }
            
            for (int i = 0; i < hist.Count(); i++)
            {
                ahist[i] = hist[i] + aux;
                aux = aux + hist[i];
            }

            for (int i = 0; i < hist.Count(); i++) //103
                brillo += hist[i] * i;

            brillo /= tam;

            for (int i = 0; i < hist.Count(); i++)
                contraste += hist[i] * (float)Math.Pow(i - brillo, 2);

            contraste = (float)Math.Sqrt(contraste / tam);


            float prob = 0, log2P = 0;
            for (int i = 0; i < 256; i++)
            {
                prob = ((float)hist[i]) / (tam);
                if (prob != 0)
                    log2P = (float)(Math.Log(prob) / Math.Log(2));
                else
                    log2P = 0;
                entropia = entropia + (prob * log2P);
            }
            entropia = entropia * -1;

            int n = 0;
            do
            {
                n++;
                min = n;
            } while (this.hist[n] == 0 && n < 255);

            n = 255;
            do
            {
                max = n;
                n--;
            } while (hist[n] == 0);
        }


        private float[] convertToScale(int[] data, int oldMin, int oldMax, int min, int max)
        {
            float oldDiff = 0 - oldMin;
            float oldScale = oldMax - oldMin;
            float diff = 0 - min;
            float scale = max - min;
            float[] ret = new float[data.Length];

            float scaledFromZeroToOne;
            float value;
            for (int i = 0; i < data.Length; i++)
            {
                scaledFromZeroToOne = (oldDiff + data[i]) / oldScale; // Normalization here [0,1]
                value = (scaledFromZeroToOne * scale) - diff;
                ret[i] = value;
            }

            return ret;
        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|Tiff files (*.tiff)|*.tiff|*.*|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                FormImagen image = new FormImagen(openFileDialog.FileName,99); // ID 99
                this.acum = new float[256];
                this.acumaux = new float[256];
                this.resul = new float[256];

                int aux = 0;
                for (int i = 0; i < m_Bitmap.Width; i++)
                {
                    for (int j = 0; j < m_Bitmap.Height; j++)
                    {
                        image.hist[m_Bitmap.GetPixel(i, j).B] += 1;
                    }
                }

                for (int i = 0; i < hist.Count(); i++)
                {
                    image.ahist[i] = hist[i] + aux;
                    aux = aux + hist[i];
                }

                float[] acum = convertToScale(image.ahist, 0, image.ahist.Last(), 0, 1);

                float[] acumaux = convertToScale(ahist, 0, ahist.Last(), 0, 1);

                for (int i = 0; i < 256; i++)
                {
                    acum[i] = acumaux[i];
                }


                for (int i = 0; i < m_Bitmap.Width; i++)
                {
                    for (int j = 0; j < m_Bitmap.Height; j++)
                    {
                        aux = m_Bitmap.GetPixel(i, j).B;

                        a_Bitmap.SetPixel(i, j, Color.FromArgb(255, acum[aux], acum[aux], acum[aux]));
                        //                        m_Bitmap.SetPixel(i, j,m_Bitmap.GetPixel(j,i));

                    }
                }


/*                int sizeo = image.m_Bitmap.Width * image.m_Bitmap.Height;
                int size2 = this.Width * this.Height;

                for (int i = 0; i < 256; i++)
                    this.acumaux[i] = image.ahist[i] / image.ahist.Last();

                for (int i = 0; i < 256; i++)
                    this.acum[i] = ahist[i] / ahist.Last();
                */
                 
                
                
                FormImagen image1 = new FormImagen(a_Bitmap, a.lastid);
                
                a.Imagenes.Add(image1);
                a.Imagenes[a.lastid].MdiParent = this.MdiParent;
                a.Imagenes[a.lastid].Show();
                a.lastid++;
                this.Invalidate();

                
            }
        }



      

        private void diferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "*.*|*.*|Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|Tiff files (*.tiff)|*.tiff";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                FormImagen image = new FormImagen(openFileDialog.FileName, a.lastid);
                FormImagen imaged = new FormImagen(openFileDialog.FileName, a.lastid);


                for (int i = 0; i < image.m_Bitmap.Width; i++)
                {
                    int valor;
                    for (int j = 0; j < image.m_Bitmap.Height; j++)
                    {
                        //Almacenamos el color del píxel
                        //                        valor= image.m_Bitmap.GetPixel(i, j).A
                        //                        this.m_Bitmap.GetPixel(i, j).A
                        valor = Math.Abs(image.m_Bitmap.GetPixel(i, j).B - this.m_Bitmap.GetPixel(i, j).B);

                        imaged.m_Bitmap.SetPixel(i, j, Color.FromArgb(Color.Red.A, valor, valor, valor));


                        if (valor > 0)
                        {

                            //Asignamos el nuevo valor 
                            image.m_Bitmap.SetPixel(i, j, Color.FromArgb(Color.Red.A, 255, 0, 0));
                        }
                    }
                }


                a.Imagenes.Add(image);
                a.Imagenes[a.lastid].MdiParent = this.MdiParent;
                a.Imagenes[a.lastid].Show();
                a.lastid++;
                this.Invalidate();

                a.Imagenes.Add(imaged);
                a.Imagenes[a.lastid].MdiParent = this.MdiParent;
                a.Imagenes[a.lastid].Show();
                a.lastid++;
                this.Invalidate();
            }
        }

        public float contraste = 0, brillo = 0, entropia = 0;
        Color[] copia;
        List<int> valores;
        public int[] hist, ahist;
            public float[] acum, acumaux,resul;
        FormPrincipal a;



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
                        int temp;
                        cx = coordinates.X;
                        cy = coordinates.Y;
                        if (cpx > cx) { temp = cpx; cpx = cx; cx = temp; }
                        if (cpy > cy) { temp = cpy; cpy = cy; cy = temp; }
                        rectx = cx - cpx;
                        recty = cy - cpy;
                        copia = new Color[rectx * recty];
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
                        /*FormPrincipal*/
                        a = (FormPrincipal)MdiParent;
                        FormImagen subImagen = new FormImagen(a_Bitmap, a.lastid);
                        a.Imagenes.Add(subImagen);
                        a.Imagenes[a.lastid].MdiParent = this.MdiParent;
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


        private void FormImagen_Activated(object sender, EventArgs e)
        {
            a = (FormPrincipal)MdiParent;
            a.activeid = this.id;
            this.Text = id.ToString();
        }











        
    }
}