using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVisite.model
{
    public class Helper
    {
        public static  double Distance(Personne cli1, Personne cli2)
        {
            return Distance(cli1.Position, cli2.Position);
        }

        private static double Distance(Geometry p1, Geometry p2)
        {
            return Math.Sqrt(Math.Pow(p1.X-p2.X,2)+ Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
