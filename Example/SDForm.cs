using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Example
{
    public partial class SDForm : Form
    {
        public SDForm()
        {
            InitializeComponent();
        }

        private void summaButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(this.SNumber1TextBox.Text);
            int num2 = Convert.ToInt32(this.SNumber2TextBox.Text);
            ClassLibrary.Class1 class1 = new ClassLibrary.Class1();
            int result = class1.summa(num1, num2);
            labelSumma.Text = Convert.ToString(result);
        }

        private void differenceButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(this.DNumber1TextBox.Text);
            int num2 = Convert.ToInt32(this.DNumber2TextBox.Text);
            ClassLibrary.Class1 class1 = new ClassLibrary.Class1();
            int result = class1.difference(num1, num2);
            labelDifference.Text = Convert.ToString(result);
        }
    }
}
