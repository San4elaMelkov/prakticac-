using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm : LayoutForm
    {
        public MainForm() :base()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Laba23 laba23 = new Laba23(this);
            laba23.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Laba31 laba31 = new Laba31(this);
            laba31.Show();
            Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Laba32 laba32 = new Laba32(this);
            laba32.Show();
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Laba34 laba34 = new Laba34(this);
            laba34.Show();
            Hide();
        }
    }
}
