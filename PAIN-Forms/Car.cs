using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_Forms
{
    public enum CarType { Osobowy, Ciezarowy, Jednosladowy }

    public class Car
    {
        public int id { get; set; }
        public String marka { get; set; }
        public int maks_v { get; set; }
        public int rok_prod { get; set; }
        public CarType rodzaj { get; set; }

        public override String ToString()
        {
            return marka + ", " + rok_prod;
        }

        public Car(int id_, String marka_, int maks_v_, int rok_prod_, CarType rodzaj_)
        {
            id = id_;
            marka = marka_;
            maks_v = maks_v_;
            rok_prod = rok_prod_;
            rodzaj = rodzaj_;
        }
    }
}
