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
    public partial class Form2 : Form
    {
        int[] b;
        public Form2(int[] a)
        {
            InitializeComponent();
            b = a;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < b.Length; i++)
                chart1.Series[0].Points.AddXY(i, b[i]);
        }
    }
}
