using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGimp
{
    public partial class FormRotar : Form
    {
        int[] hist, nhist;
        int[] y;
        int id;
        int angle;
        float A, B;
        FormPrincipal a;
        public System.Drawing.Bitmap a_Bitmap, m_Bitmap;
        public FormRotar(System.Drawing.Bitmap m_Bitmap, int[] hist, int id)
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
            a = (FormPrincipal)MdiParent;

            // Get the angle.
            angle = Int32.Parse(grados.Text);
       

            // Rotate.
            a_Bitmap = RotateBitmap(m_Bitmap, angle);

            // Display the result.
            FormImagen subImagen = new FormImagen(a_Bitmap, a.lastid);
            
            int wid = subImagen.pictureBox1.Right + subImagen.pictureBox1.Left;
            int hgt = subImagen.pictureBox1.Bottom + subImagen.pictureBox1.Left;
            this.ClientSize = new Size(
                Math.Max(wid, this.ClientSize.Width),
                Math.Max(hgt, this.ClientSize.Height));


            
            a.Imagenes.Add(subImagen);
            a.Imagenes[a.lastid].MdiParent = this.MdiParent;
            a.Imagenes[a.lastid].Show();
            a.lastid++;
            // Size the form to fit.
            
        }

        // Return a bitmap rotated around its center.
        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            // Make a Matrix to represent rotation by this angle.
            Matrix rotate_at_origin = new Matrix();
            rotate_at_origin.Rotate(angle);

            // Rotate the image's corners to see how big
            // it will be after rotation.
            PointF[] points =
            {
                new PointF(0, 0),
                new PointF(bm.Width, 0),
                new PointF(bm.Width, bm.Height),
                new PointF(0, bm.Height),
            };
            rotate_at_origin.TransformPoints(points);
            float xmin, xmax, ymin, ymax;
            GetPointBounds(points, out xmin, out xmax, out ymin, out ymax);

            // Make a bitmap to hold the rotated result.
            int wid = (int)Math.Round(xmax - xmin);
            int hgt = (int)Math.Round(ymax - ymin);
            Bitmap result = new Bitmap(wid, hgt);

            // Create the real rotation transformation.
            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle,
                new PointF(wid / 2f, hgt / 2f));

            // Draw the image onto the new bitmap rotated.
            using (Graphics gr = Graphics.FromImage(result))
            {
                // Use smooth image interpolation.
                gr.InterpolationMode = InterpolationMode.High;

                // Clear with the color in the image's upper left corner.
                gr.Clear(bm.GetPixel(0, 0));

                // Set up the transformation to rotate.
                gr.Transform = rotate_at_center;

                // Draw the image centered on the bitmap.
                int x = (wid - bm.Width) / 2;
                int y = (hgt - bm.Height) / 2;
                gr.DrawImage(bm, x, y);
            }
            
            // Return the result bitmap.
            return result;
        }

        // Find the bounding rectangle for an array of points.
        private void GetPointBounds(PointF[] points, out float xmin, out float xmax, out float ymin, out float ymax)
        {
            xmin = points[0].X;
            xmax = xmin;
            ymin = points[0].Y;
            ymax = ymin;
            foreach (PointF point in points)
            {
                if (xmin > point.X) xmin = point.X;
                if (xmax < point.X) xmax = point.X;
                if (ymin > point.Y) ymin = point.Y;
                if (ymax < point.Y) ymax = point.Y;
            }
        }


        
    }
}
