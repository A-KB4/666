using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryVolumeCalculator
{
    public class Pyramid : Solid
    {
        public double A { get; set; }  // Довжина сторони основи
        public double H { get; set; }  // Висота піраміди

        public Pyramid(double a, double h)
        {
            A = a;
            H = h;
        }

        public override double GetVolume()
        {
            return (1.0 / 3.0) * A * A * H;
        }
    }
}
