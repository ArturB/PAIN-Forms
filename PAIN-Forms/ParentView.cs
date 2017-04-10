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
        int carsCount { get; set; }

        public Car getCarByIndex(int index)
        {
            foreach(Car c in cars)
            {
                if (c.id == index)
                {
                    return c;
                }
            }
            throw new NoSuchIndex();
        }

        public String ToolStripText
        {
            get
            {
                return toolStripStatusLabel1.Text;
            }
            set
            {
                toolStripStatusLabel1.Text = value;
            }
        }


        public ParentView()
        {
            InitializeComponent();
            cars = new List<Car>();
            cars.Add(new PAIN_Forms.Car(1, "Chevrolet", 180, 2005, CarType.Osobowy));
            cars.Add(new Car(2, "Scania", 140, 1999, CarType.Ciezarowy));
            cars.Add(new Car(3, "Romet", 50, 2010, CarType.Jednosladowy));
            carsCount = 3;
        }

        public void AddCar(Car c)
        {
            carsCount++;
            c.id = carsCount;
            cars.Add(c);
            foreach(CarView cv in MdiChildren)
            {
                cv.AddCar(c);
            }

        }

        public void EditCar(Car c)
        {
            foreach(Car uc in cars)
            {
                if(uc.id == c.id)
                {
                    uc.marka = c.marka;
                    uc.rodzaj = c.rodzaj;
                    uc.rok_prod = c.rok_prod;
                    uc.maks_v = c.maks_v;
                    break;
                }
            }
            foreach (CarView cv in MdiChildren)
            {
                cv.EditCar(c);
            }
        }

        public void DeleteCar(Car c)
        {
            foreach(Car uc in cars)
            {
                if(uc.id == c.id)
                {
                    cars.Remove(uc);
                    break;
                }
            }
            
            foreach(CarView cv in MdiChildren)
            {
                cv.DeleteCar(c);
            }
        }

        public void ReloadData(List<Car> c)
        {
            cars = c;
            foreach(CarView cv in MdiChildren)
            {
                cv.ReloadData(c);
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
            f.ReloadData(cars);
            f.Show();
        }

        private void ParentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ParentView_MdiChildActivate(object sender, EventArgs e)
        {
            ToolStripText = ((CarView)ActiveMdiChild).ToolStripText;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
    class NoSuchIndex : Exception { }
}
