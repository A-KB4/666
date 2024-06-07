using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryVolumeCalculator
{
    public class Pyramid : ISolid
    {
        public double A { get; set; }  // Довжина сторони основи
        public double H { get; set; }  // Висота піраміди

        public Pyramid(double a, double h)
        {
            A = a;
            H = h;
        }

        public double GetVolume()
        {
            return (1.0 / 3.0) * A * A * H;
        }
    }
}

