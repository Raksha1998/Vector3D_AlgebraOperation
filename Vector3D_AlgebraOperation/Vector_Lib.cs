﻿using System;
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

        /// <summary>
        /// Reverse/Negate vector
        /// </summary>
        public void Reverse_Negate()
        { X = -X; Y = -Y; Z = -Z; }

        /// <summary>
        /// Addition of 2 vectors
        /// </summary>
        /// <param name="v1">input vector</param>
        /// <param name="v2">input vector</param>
        /// <returns>add input1 and input2</returns>
        public static Vector3D addition(Vector3D v1, Vector3D v2)
        {
            double v3_x = v1.X + v2.X;
            double v3_y = v1.Y + v2.Y;
            double v3_z = v1.Z + v2.Z;

            Vector3D v3 = new Vector3D(v3_x, v3_y, v3_z);

            return v3;

        }

        /// <summary>
        /// Subtraction of 2 vector
        /// </summary>
        /// <param name="v1">input vector</param>
        /// <param name="v2">input vector</param>
        /// <returns></returns>
        public static Vector3D subtraction(Vector3D v1, Vector3D v2)
        {
            double v3_x = v1.X - v2.X;
            double v3_y = v1.Y - v2.Y;
            double v3_z = v1.Z - v2.Z;

            Vector3D v3 = new Vector3D(v3_x, v3_y, v3_z);

            return v3;

        }

    }

}
