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
    public partial class CarAdd : Form
    {
        CarTypeChooser chooser;
        ParentView parent;

        public CarAdd(ParentView parent_)
        {
            InitializeComponent();
            parent = parent_;
        }

        private void CarEdit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CarEdit_Load(object sender, EventArgs e)
        {
            chooser = new CarTypeChooser();
            tableLayoutPanel1.Controls.Add(chooser, 1, 3);
            tableLayoutPanel1.SetColumnSpan(chooser, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car c = new PAIN_Forms.Car(
                0, 
                markaTextBox.Text, 
                int.Parse(rokTextBox.Text), 
                int.Parse(rokTextBox.Text), 
                chooser.choosedType()
                );
            parent.AddCar(c);
            this.Close();
        }
    }
}
