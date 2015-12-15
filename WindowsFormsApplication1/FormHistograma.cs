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
    public partial class FormHistograma : Form
    {
        int[] b;
        int id, min, max;
        float brillo, contraste, entropia;
        public FormHistograma(int[] a, int id, float brillo, float contraste, float entropia, int min, int max)
        {
            InitializeComponent();
            b = a;
            this.id = id;
            this.min = min;
            this.max = max;
            this.brillo = brillo;
            this.contraste = contraste;
            this.entropia = entropia;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBrillo.Text = brillo.ToString();
            textContraste.Text = contraste.ToString();
            textEntropia.Text = entropia.ToString();
            textMinmax.Text = "[" + min.ToString() + ", " + max.ToString() + "]";
            this.Text = "Histograma " + id.ToString();
            for (int i = 0; i < b.Length; i++)
                chart1.Series[0].Points.AddXY(i, b[i]);
        }
    }
}
