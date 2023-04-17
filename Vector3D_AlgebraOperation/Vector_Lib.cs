using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector3D_AlgebraOperation
{
    public class Vector_Lib
    {
    }

    /// <summary>
    /// Representation of 3D Vector
    /// </summary>
    public struct Vector3D
    {
        //Components of 3D Vector
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //constructors used to store data and validate if its constrained
        public Vector3D(double _x, double _y, double _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
    }

}
