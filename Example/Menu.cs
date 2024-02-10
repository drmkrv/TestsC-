using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SDButton_Click(object sender, EventArgs e)
        {
            SDForm sd = new SDForm();
            sd.Show();
        }

        private void LBButton_Click(object sender, EventArgs e)
        {
            LBForm lb = new LBForm();
            lb.Show();
        }
    }
}
