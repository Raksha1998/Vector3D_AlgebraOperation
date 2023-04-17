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

        /// <summary>
        /// Multiplication of a vector with a scalar
        /// </summary>
        /// <param name="a_Scalar">scalar input</param>
        /// <param name="v_vector">vector to be multiplied</param>
        /// <returns>vector</returns>
        public static Vector3D ScalarMultiplication(double a, Vector3D v)
        {
            double v3_x = v.X * a;
            double v3_y = v.Y * a;
            double v3_z = v.Z * a;

            Vector3D v3 = new Vector3D(v3_x, v3_y, v3_z);

            return v3;

        }

        /// <summary>
        /// Division of a vector by scalar
        /// </summary>
        /// <param name="a">scalar input</param>
        /// <param name="v">vector to be divided by scalar</param>
        /// <returns>vector</returns>
        public static Vector3D division(double a, Vector3D v)
        {
            double v3_x = v.X / a;
            double v3_y = v.Y / a;
            double v3_z = v.Z / a;

            Vector3D v3 = new Vector3D(v3_x, v3_y, v3_z);

            return v3;

        }

        /// <summary>
        /// Dot Product of two vectors
        /// </summary>
        /// <param name="v1">vector input</param>
        /// <param name="v2">vector input</param>
        /// <returns></returns>
        public static double DotProduct(Vector3D v1, Vector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        /// <summary>
        /// Cross Product of two vector
        /// </summary>
        /// <param name="v1">vector input</param>
        /// <param name="v2">vector input</param>
        /// <returns>perpendicular vector</returns>
        public static Vector3D CrossProduct(Vector3D v1, Vector3D v2)
        {
            double v3_x = v1.Y * v2.Z - v1.Z * v2.Y;
            double v3_y = v1.Z * v2.X - v1.X * v2.Z;
            double v3_z = v1.X * v2.Y - v1.Y * v2.X;

            Vector3D v3 = new Vector3D(v3_x, v3_y, v3_z);

            return v3;
        }

        /// <summary>
        /// Length of Vector
        /// </summary>       
        public double Get_Length()
        {
            double sqlength = X * X + Y * Y + Z * Z;
            double length = Math.Sqrt(sqlength);
            return length;
        }
        public double Length
        {
            get
            {
                return Get_Length();
            }
        }

        /// <summary>
        /// Angle between two vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>

        public static double Get_Angle(Vector3D a, Vector3D b)
        {
            double dot_product = DotProduct(a, b);
            double magnitude_a = a.Length;
            double magnitude_b = b.Length;
            double angle = Math.Acos(dot_product / (magnitude_a * magnitude_b));// angle in radians
            double degree = angle * 180 / Math.PI;//converting angle fromradians to degree

            return degree;
        }

        /// <summary>
        /// Equality and Inequlaity of two vectors
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vector3D v1, Vector3D v2)
        {
            if (ReferenceEquals(v1, v2))
                return true;

            return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;

        }
        public static bool operator !=(Vector3D v1, Vector3D v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return $"[{X},{Y},{Z}]";
        }

    }

}
