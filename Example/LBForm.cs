using System;
using System.Collections;
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
    public partial class LBForm : Form
    {
        public LBForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.labelList.Text == ".") labelList.Text = null;
            string letter = letterTextBox.Text;
            List<string> letters = new List<string> { labelList.Text };
            ClassLibrary.Class2 class2 = new ClassLibrary.Class2();
            List<string> result = class2.ListWithLetters(letters, letter);
            string list = string.Join("", result.ToArray());
            labelList.Text = list;
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            ClassLibrary.Class2 class2 = new ClassLibrary.Class2();
            bool result = class2.FuncReturnTrueOrFalse(Convert.ToInt16(numericUpDown.Value));
            labelBool.Text = Convert.ToString(result);
        }
    }
}
