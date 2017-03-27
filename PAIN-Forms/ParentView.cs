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
        public int carsCount { get; set; }

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

        public List<Car> before2000()
        {
            List<Car> result = new List<Car>();
            foreach(Car c in cars)
            {
                if(c.rok_prod < 2000)
                {
                    result.Add(c);
                }
            }
            return result;
        }

        public List<Car> after2000()
        {
            List<Car> result = new List<Car>();
            foreach (Car c in cars)
            {
                if (c.rok_prod >= 2000)
                {
                    result.Add(c);
                }
            }
            return result;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarView f = new CarView(this);
            f.MdiParent = this;
            f.LoadData(cars);
            f.Show();
        }

        private void ParentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    class NoSuchIndex : Exception { }
}
