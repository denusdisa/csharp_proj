using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_proj
{
    class Circle:Dot
    {
        double radius = 1; //радіус кола 

        public Circle()
        {
        }

        public  Circle(double rad, double X, double Y) :base(X, Y)
        {
            radius = rad;
        }
        ~Circle()
        {
        }
 
    public 	double getRad()
    {

        return radius;
    }

        public  void setRad(double value)
    {
        if (value > 0)
           radius = value;
        else
          throw new ApplicationException("Радіус має бути додатнім числом");
        }
public    bool Check_intersect(Circle val)
    {
        double distance = Math.Sqrt((Math.Pow(x - val.X, 2)) + (Math.Pow(y - val.Y, 2)));
        if ((radius + val.getRad()) < distance)
            return false;
        else
            return true;
    }
 public   bool Check_similar(Circle val)
    {
        if (val.getRad() == radius)
        {
            if (val.X == x)
            {
                if (val.Y == y)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        else
            return false;
    }


}
}
