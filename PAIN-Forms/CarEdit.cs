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
        CarTypeChooser chooser;
        ParentView parent;
        Car editedCar;

        public CarEdit(ParentView parent_, Car editedCar_)
        {
            InitializeComponent();

            chooser = new CarTypeChooser();
            tableLayoutPanel1.Controls.Add(chooser, 1, 4);
            tableLayoutPanel1.SetColumnSpan(chooser, 2);

            parent = parent_;
            editedCar = editedCar_;
            markaTextBox.Text = editedCar.marka;
            rokTextBox.Text = editedCar.rok_prod.ToString();
            PredkoscTextBox.Text = editedCar.maks_v.ToString();
            chooser.imageIndex = (int)editedCar.rodzaj;
        }

        private void CarEdit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CarEdit_Load(object sender, EventArgs e)
        {
            
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
