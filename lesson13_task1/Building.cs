using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13_task1
{
    class Building
    {
        const double defaultValue = 20;
        string address;
        double bLength;
        double bWidth;
        double bHeight;

        public string Address {
            get { return address; }
            set { address = value; }
        }
        public double BLength {
            get { return bLength; }
            set
            {
                bLength = (value > 0) ? value : defaultValue;
            }
        }
        public double BWidth {
            get { return bWidth; }
            set
            {
                bWidth = (value > 0) ? value : defaultValue;
            }
        }
        public double BHeight {
            get { return bHeight; }
            set
            {
                bHeight = (value > 0) ? value : defaultValue;
            }
        }

        public Building(string address, double bLength, double bWidth, double bHeight)
        {
            Address = address;
            BLength = bLength;
            BWidth = bWidth;
            BHeight = bHeight;
        }

        public string Print()
        {
            return $"Характеристики здания: \n" +
                $"Адрес {Address} \n" +
                $"Длина - {BLength}, ширина - {BWidth}, высота - {BHeight}";
        }
    }
}
