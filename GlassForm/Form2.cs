using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var op = 1.0;
            for (int i = 0; i < 30; i++)
            {
                this.Opacity = op;
                op = op - 0.05;
                Thread.Sleep(100);
            }
        }
    }
}
