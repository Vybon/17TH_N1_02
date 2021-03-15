using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int tru = truhaiso(2, 3);
        }
        public int tonghaiso(int a, int b)
        {
            return a + b;
        }
        public int truhaiso(int x, int y)
        {
            return x - y;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
