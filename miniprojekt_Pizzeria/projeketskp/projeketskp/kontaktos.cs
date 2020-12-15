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
    public partial class kontaktos : Form
    {
        public kontaktos()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Forms1 f = new Forms1(); // This is bad
            this.Hide();
            f.Show();
        }

        private void lavselvButton_Click(object sender, EventArgs e)
        {
            laveselv f = new laveselv(); // This is bad
            this.Hide();
            f.Show();
        }
    }
}
