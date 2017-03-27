using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_Forms
{
    interface ICarViewer
    {
        void AddCar(Car c);
        void EditCar(Car c);
        void DeleteCar(Car c);
        void foo();
    }
}
