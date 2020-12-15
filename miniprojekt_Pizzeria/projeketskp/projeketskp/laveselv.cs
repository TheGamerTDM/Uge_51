using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeketskp
{
    public partial class laveselv : Form
    {
        public laveselv()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Forms1 f = new Forms1(); // This is bad
            this.Hide();
            f.Show();
        }

        private void kontakosButton_Click(object sender, EventArgs e)
        {
            kontaktos f = new kontaktos(); // This is bad
            this.Hide();
            f.Show();
        }
    }
}
