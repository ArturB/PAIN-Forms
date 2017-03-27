using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_Forms
{
    public partial class CarEdit : Form
    {
        public CarEdit()
        {
            InitializeComponent();
        }

        private void CarEdit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CarEdit_Load(object sender, EventArgs e)
        {
            CarTypeChooser chooser = new CarTypeChooser();
            tableLayoutPanel1.Controls.Add(chooser, 1, 3);
            tableLayoutPanel1.SetColumnSpan(chooser, 2);
        }
    }
}
