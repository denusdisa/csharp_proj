using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_proj
{
     class Dot
    {
      public  double x = 0;
        public double y = 0;

        public Dot()
        { }
public Dot(double X, double Y)
        {
            x = X;
            y = Y;
        }
        public Dot(double X)
        {
            x = X;
        }
        ///конструктор копій
       public Dot(Dot previousdot)
        {
            x = previousdot.X;
            y = previousdot.Y;
        }
        public double X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public double Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        
        public override string ToString()
        {
            return x+" "+y;
        }

        public static Dot operator + (Dot val1, Dot val2)
        {
            Dot temp = new Dot(0,0);
            temp.X = val1.X + val2.X;
            temp.Y = val1.Y + val2.Y;
            return temp;
        }
     public static Dot operator - (Dot val1, Dot val2)
        {
            Dot temp = new Dot(0, 0);
            temp.X = val1.X -val2.X;
            temp.Y = val1.Y - val2.Y;
            return temp;
        }
     public static Dot operator * (Dot val1, double val)
        {
            Dot temp = new Dot(0, 0);
            temp.X = val1.X *val;
            temp.Y = val1.Y *val;
            return temp;
        }
        public static Dot operator /(Dot val1, double val)
        {
            Dot temp = new Dot(0, 0);
            temp.X = val1.X / val;
            temp.Y = val1.Y / val;
            return temp;
        }
        //public static Dot operator ==(Dot val1, Dot val2)
        //{
        //    val1.x = val2.x;
        //    val1.y = val2.y;
        //}
    }
}
