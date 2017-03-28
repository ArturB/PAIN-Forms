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

        public CarEdit(ParentView parent_, Car editedCar_)
        {
            InitializeComponent();

            chooser = new CarTypeChooser();
            tableLayoutPanel1.Controls.Add(chooser, 1, 4);
            tableLayoutPanel1.SetColumnSpan(chooser, 2);

            parent = parent_;
            idTextBox.Text = editedCar_.id.ToString();
            markaTextBox.Text = editedCar_.marka;
            rokTextBox.Text = editedCar_.rok_prod.ToString();
            PredkoscTextBox.Text = editedCar_.maks_v.ToString();
            chooser.imageIndex = (int)editedCar_.rodzaj;
        }

        private void CarEdit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CarEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            Car c = new PAIN_Forms.Car(
                int.Parse(idTextBox.Text),
                markaTextBox.Text,
                int.Parse(PredkoscTextBox.Text),
                int.Parse(rokTextBox.Text), 
                chooser.choosedType()
                );
            parent.EditCar(c);
            this.Close();
        }

        private void Usuń_Click(object sender, EventArgs e)
        {
            Car c = new PAIN_Forms.Car(
                int.Parse(idTextBox.Text),
                markaTextBox.Text,
                int.Parse(PredkoscTextBox.Text),
                int.Parse(rokTextBox.Text),
                chooser.choosedType()
                );
            parent.DeleteCar(c);
            this.Close();
        }
    }
}
