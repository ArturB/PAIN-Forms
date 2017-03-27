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
    public partial class CarView : Form
    {
        ParentView parent;

        public CarView(ParentView parent_) 
        {
            InitializeComponent();
            parent = parent_;
        }

        public int CarImageIndex(Car c)
        {
            if(c.rodzaj == CarType.Osobowy)
            {
                return 0;
            }
            else if(c.rodzaj == CarType.Ciezarowy)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public void InitData()
        {
            listView1.SmallImageList = CarTypesImages;
            listView1.StateImageList = CarTypesImages;
            listView1.LargeImageList = CarTypesImages;
            foreach (Car c in ((ParentView)this.ParentForm).cars)
            {
                listView1.Items.Add(c.ToString(), CarImageIndex(c));
            }
        }

        public void AddCar(Car c)
        {
            listView1.Items.Add(c.ToString(), CarImageIndex(c));
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.ParentForm.MdiChildren.Count() == 1 && e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void ciezarowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAdd editDialog = new CarAdd(parent);
            editDialog.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void osobowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAdd editDialog = new CarAdd(parent);
            editDialog.ShowDialog();
        }

        private void jednośladToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAdd editDialog = new CarAdd(parent);
            editDialog.ShowDialog();
        }

        private void CarView_Load(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }
    }
}
