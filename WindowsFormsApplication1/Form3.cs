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
    public partial class Form3 : Form
    {
        int[] b;
        int aux=0;
        public Form3(int[] a)
        {
            InitializeComponent();
            b = a;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < b.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, b[i]+aux);
                aux = aux + b[i];
            }
        }
    }
}
