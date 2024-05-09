using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynNCXLib.GeometryWrapper
{
    public class Point
    {
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.z = 0.0;
        }

        public static Point ByCoordinates(double x, double y, double z = 0.0)
        {
            Point p = new Point(x, y, z);
            return p;
        }
        public double X => this.x;
        public double Y => this.y;
        public double Z => this.z;

        protected double x;
        protected double y;
        protected double z;
    }

    public class Vector
    {
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.z = 0.0;
        }

        public static Vector ByCoordinates(double x, double y, double z = 0.0)
        {
            Vector p = new Vector(x, y, z);
            return p;
        }
        public double X => this.x;
        public double Y => this.y;
        public double Z => this.z;

        protected double x;
        protected double y;
        protected double z;
    }


}
