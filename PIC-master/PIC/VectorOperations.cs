using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    public class VectorOperations:Vector
    {
        public VectorOperations(double x, double y, double z) : base(x, y, z)
        {
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            VectorOperations add = new VectorOperations(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
            return add;
        }

        
        public static Vector Subtract(Vector v1, Vector v2)
        {
            VectorOperations subs = new VectorOperations(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
            return subs; 
         }

        public static double Product(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
    }
}
