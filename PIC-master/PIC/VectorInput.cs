using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    public class VectorInput : Vector
    {
        
        public VectorInput(double x, double y, double z) : base(x, y, z)
        {
        }

        public static VectorInput Usuario(string prompt)
        {
            
            double x = InputValidator.GetDoubleInput(prompt + " Componente X: ");
            double y = InputValidator.GetDoubleInput(prompt + " Componente Y: ");
            double z = InputValidator.GetDoubleInput(prompt + " Componente Z: ");
            VectorInput vector = new VectorInput(x,y,z);
            return vector;
        }

     }
}

   
