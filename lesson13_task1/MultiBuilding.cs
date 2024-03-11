using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13_task1
{
    sealed class MultiBuilding :Building
    {
        int floorNumber;
        public int FloorNumber {
            get { return floorNumber; }
            set
            {
                floorNumber = (value > 0) ? value : 1;
            }
        }

        public MultiBuilding(string address, double bLength, double bWidth, double bHeight, int floorNumber)
            :base(address, bLength, bWidth, bHeight)
        {
            FloorNumber = floorNumber;
        }

        public string Print()
        {
            string result = base.Print();
            return result + $", количество этажей - {FloorNumber}";
        }
    }
}
