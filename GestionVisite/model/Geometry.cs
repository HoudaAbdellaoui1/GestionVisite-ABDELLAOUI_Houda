using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVisite.model
{
    public class Geometry
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Geometry()
        {

        }
        public Geometry(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Geometry(string txtX, string txtY)
        {
            this.X = double.Parse(txtX);
            this.Y = double.Parse(txtY);
        }

    }
}
