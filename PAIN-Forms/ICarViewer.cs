using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_Forms
{
    public delegate bool CarsFilter(Car c);

    public interface ICarViewer
    {
        void AddCar(Car c);
        void EditCar(Car c);
        void DeleteCar(Car c);
        void ReloadData(List<Car> c);
        CarsFilter currentFilter { get; set; }
        void Filter();
    }
}
