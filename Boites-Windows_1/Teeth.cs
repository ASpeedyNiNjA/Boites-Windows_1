using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boites_Windows_1
{
    public partial class Teeth : Form
    {
        public Teeth()
        {
            InitializeComponent();
        }

        private void brush_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the CheckBox.CheckedChanged event.");

        }
    }
}
