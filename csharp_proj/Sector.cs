using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_proj
{
    class Sector:Dot
    {
        double radius;
        double edge;
        Sector(double rad, double edg, double X, double Y) :base(X, Y)
        {
            radius = rad;
            edge = edg;
        }
        public double Radius
        {
            set
            {
                radius = value;
            }
            get
            {
                return radius;
            }
        }
        public double Edge
        {
            set
            {
                edge = value;
            }
            get
            {
                return edge;
            }
        }

        ~Sector()
        {
        }

}
}
