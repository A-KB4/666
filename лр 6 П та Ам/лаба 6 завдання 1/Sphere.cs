using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryVolumeCalculator
{
    public class Sphere : Solid
    {
        public double R { get; set; }  // Радіус кулі

        public Sphere(double r)
        {
            R = r;
        }

        public override double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
        }
    }
}
