using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Laba23 : Form
    {
        Home parent;
        public Laba23(Home parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void Laba23_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
