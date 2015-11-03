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
    public partial class FormHistogramaAbs : Form
    {
        int[] b;
        int aux=0;
        int id;
        public FormHistogramaAbs(int[] a, int id)
        {
            InitializeComponent();
            b = a;
            this.id = id;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "HistogramaAbs " + id.ToString(); 
            for (int i = 0; i < b.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, b[i]+aux);
                aux = aux + b[i];
            }
        }
    }
}
