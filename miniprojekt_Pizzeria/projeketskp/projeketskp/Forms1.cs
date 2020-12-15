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
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }

        private void kontakosButton_Click(object sender, EventArgs e)
        {
            kontaktos f = new kontaktos();
            this.Hide();
            f.Show();
        }

        private void lavselvButton_Click(object sender, EventArgs e)
        {
            laveselv f = new laveselv();
            this.Hide();
            f.Show();
        }
    }


}
