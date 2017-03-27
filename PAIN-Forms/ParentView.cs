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
    public partial class ParentView : Form
    {
        public List<Car> cars { get; set; }

        public ParentView()
        {
            InitializeComponent();
            cars = new List<Car>();
            cars.Add(new PAIN_Forms.Car(1, "Chevrolet", 180, 2005, CarType.Osobowy));
            cars.Add(new Car(2, "Scania", 140, 1999, CarType.Ciezarowy));
            cars.Add(new Car(3, "Romet", 50, 2010, CarType.Jednosladowy));
        }

        public void AddCar(Car c)
        {
            cars.Add(c);
            foreach(CarView cv in MdiChildren)
            {
                cv.AddCar(c);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarView f = new CarView(this);
            f.MdiParent = this;
            f.InitData();
            f.Show();
        }

        private void ParentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
