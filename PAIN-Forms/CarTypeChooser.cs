using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_Forms
{
    public partial class CarTypeChooser : UserControl
    {
        int imageIndex;

        public String imageDescription()
        {
            if (imageIndex == 0)
            {
                return "Osobowy";
            }
            else if (imageIndex == 1)
            {
                return "Ciężarowy";

            }
            else if (imageIndex == 2)
            {
                return "Jednoślad";
            }
            else return "Unknown";
        }

        public CarTypeChooser()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
            imageIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imageIndex = (imageIndex + 1) % 3;
            pictureBox1.Image = imageList1.Images[imageIndex];
            label1.Text = imageDescription();
        }
    }
}
