using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            chooser.typeChanged += new CarTypeChangedHandler(choosed_typeChanged);
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

        private void choosed_typeChanged(object sender, CarTypeChanged e)
        {
            typeTextBox.Text = e.newType;
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            markaTextBox_Validated(null, null);
            rokTextBox_Validated(null, null);
            PredkoscTextBox_Validated(null, null);
            if (
                errorProvider1.GetError(markaTextBox) == String.Empty &&
                errorProvider1.GetError(rokTextBox) == String.Empty &&
                errorProvider1.GetError(PredkoscTextBox) == String.Empty
              )
            {
                Car c = new PAIN_Forms.Car(
                    int.Parse(idTextBox.Text),
                    markaTextBox.Text,
                    int.Parse(PredkoscTextBox.Text),
                    int.Parse(rokTextBox.Text),
                    chooser.choosedType
                );
                parent.EditCar(c);
                this.Close();
            }
                
        }

        private void Usuń_Click(object sender, EventArgs e)
        {
            Car c = new PAIN_Forms.Car(
                int.Parse(idTextBox.Text),
                markaTextBox.Text,
                int.Parse(PredkoscTextBox.Text),
                int.Parse(rokTextBox.Text),
                chooser.choosedType
                );
            parent.DeleteCar(c);
            this.Close();
        }

        private void markaTextBox_Validated(object sender, EventArgs e)
        {
            if (markaTextBox.Text == "")
            {
                errorProvider1.SetError(markaTextBox, "Pole wymagane!");
            }
            else if (!new Regex("^[A-Z][A-Za-z 0-9]+$").IsMatch(markaTextBox.Text))
            {
                errorProvider1.SetError(
                    markaTextBox,
                    "Nazwa marki musi zaczynać się z wielkiej litery i nie może zawierać znaków specjalnych!"
                );
            }
            else
            {
                errorProvider1.SetError(markaTextBox, String.Empty);
            }
        }

        private void rokTextBox_Validated(object sender, EventArgs e)
        {
            if (rokTextBox.Text == "")
            {
                errorProvider1.SetError(rokTextBox, "Pole wymagane!");
            }
            else if (!new Regex("^[1-2][0-9][0-9][0-9]$").IsMatch(rokTextBox.Text))
            {
                errorProvider1.SetError(
                    rokTextBox,
                    "Niepoprawny rok produkcji!"
                );
            }
            else
            {
                errorProvider1.SetError(rokTextBox, String.Empty);
            }
        }

        private void PredkoscTextBox_Validated(object sender, EventArgs e)
        {
            if (PredkoscTextBox.Text == "")
            {
                errorProvider1.SetError(PredkoscTextBox, "Pole wymagane!");
            }
            else if (!new Regex("^[0-9]+$").IsMatch(PredkoscTextBox.Text))
            {
                errorProvider1.SetError(
                    PredkoscTextBox,
                    "Niepoprawna prędkość maksymalna!"
                );
            }
            else
            {
                errorProvider1.SetError(PredkoscTextBox, String.Empty);
            }
        }
    }
}
