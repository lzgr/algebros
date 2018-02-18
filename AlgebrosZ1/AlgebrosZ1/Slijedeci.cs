using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgebrosZ1
{
    public partial class Slijedeci : Form
    {
        public Slijedeci(string nextApi)
        {
            InitializeComponent();
            nxtTask.Text = nextApi;
        }

        private void nxtButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(nxtTask.Text);
            Application.Exit();
        }
    }
}
