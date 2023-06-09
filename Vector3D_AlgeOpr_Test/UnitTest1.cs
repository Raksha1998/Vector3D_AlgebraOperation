using Vector3D_AlgebraOperation;

namespace Vector3D_AlgeOpr_Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Unit Test for Reverse/Negate of Vector
        /// </summary>
        [TestMethod]
        public void TestReverse_Negate()
        {
            //Arrange
            Vector3D v0 = new Vector3D(1, 0, 0);
            Vector3D v1 = new Vector3D(1, 0, 0);

            //Act
            v0.Reverse_Negate();
            v1.Reverse_Negate();

            //Assert
            Assert.AreEqual(v0, v1);

        }
        /// <summary>
        /// Unit Test for Addition of two vector
        /// </summary>

        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            Vector3D v_expected = new Vector3D(2, 4, 6);
            Vector3D v0 = new Vector3D(1, 2, 3);
            Vector3D v1 = new Vector3D(1, 2, 3);

            //Act
            Vector3D v_actual = Vector3D.addition(v0, v1);

            //Assert
            Assert.AreEqual(v_expected, v_actual);
        }

        /// <summary>
        /// Unit test for Subtraction of two vector
        /// </summary>
        [TestMethod]
        public void TestSub()
        {
            //Arrange
            Vector3D v_expected = new Vector3D(0, 0, 0);
            Vector3D v0 = new Vector3D(1, 2, 3);
            Vector3D v1 = new Vector3D(1, 2, 3);

            //Act
            Vector3D v_actual = Vector3D.subtraction(v0, v1);

            //Assert
            Assert.AreEqual(v_expected, v_actual);
        }


        /// <summary>
        /// Unit test for multiplication of a vector with scalar
        /// </summary>
        [TestMethod]
        public void TestMul()
        {
            //Arrange
            Vector3D v_expected = new Vector3D(2, 4, 6);


            Vector3D v1 = new Vector3D(1, 2, 3);
            //Act
            Vector3D v_actual = Vector3D.ScalarMultiplication(2, v1);

            //Assert
            Assert.AreEqual(v_expected, v_actual);
        }

        /// <summary>
        /// Unit test for division of vector by scalar
        /// </summary>

        [TestMethod]
        public void TestDiv()
        {
            //Arrange
            Vector3D v_expected = new Vector3D(1, 2, 3);

            Vector3D v1 = new Vector3D(2, 4, 6);

            //Act
            Vector3D v_actual = Vector3D.division(2, v1);

            //Assert
            Assert.AreEqual(v_expected, v_actual);
        }


        /// <summary>
        /// Unit test for dot product of two vector
        /// </summary>
        [TestMethod]
        public void TestDotProd()
        {
            //Arrange
            double dotprod_expected = 14;

            Vector3D v1 = new Vector3D(1, 2, 3);
            Vector3D v2 = new Vector3D(1, 2, 3);
            //Act
            double dotprod_actual = Vector3D.DotProduct(v1, v2);

            //Assert
            Assert.AreEqual(dotprod_expected, dotprod_actual);
        }

        /// <summary>
        /// Unit test for Cross Product of two vector
        /// </summary>
        [TestMethod]
        public void TestCrossProduct()
        {
            //Arrange
            Vector3D v0 = new Vector3D(1, 0, 0);
            Vector3D v1 = new Vector3D(0, 1, 0);
            Vector3D cross_exp = new Vector3D(0, 0, 1);

            //Act
            Vector3D cross_actual = Vector3D.CrossProduct(v0, v1);

            //Assert
            Assert.AreEqual(cross_exp, cross_actual);
        }

        /// <summary>
        /// Unit test of length of a vector
        /// </summary>
        [TestMethod]
        public void Test_Length()
        {
            //Arrange
            Vector3D v_len = new Vector3D(0, 4, 3);
            double length_Expected = 5;

            //Act
            double length_actual = v_len.Length;

            //Assert
            Assert.AreEqual(length_Expected, length_actual);
        }
        /// <summary>
        /// Unit test for Angle between two vector
        /// </summary>
        [TestMethod]

        public void Test_getangle()
        {
            //Arrange
            double angle_expected = 33.21091076089908;
            Vector3D v1 = new Vector3D(2, -1, 3);
            Vector3D v2 = new Vector3D(2, 0, 1);

            //Act
            double angle_actual = Vector3D.Get_Angle(v1, v2);

            //Assert
            Assert.AreEqual(angle_expected, angle_actual);
        }


        /// <summary>
        /// Unit test for equality and inequality of two vector
        /// </summary>
        [TestMethod]

        public void Test_equality()
        {
            //Arrange
            Vector3D v0 = new Vector3D(1, 2, 3);
            Vector3D v1 = new Vector3D(1, 2, 3);

            //Act
            Boolean arequal = v0 == v1;


            //Assert
            Assert.IsTrue(arequal);

        }

      
        [TestMethod]

        public void Test_inequality()
        {
            //Arrange
            Vector3D v0 = new Vector3D(1, 2, 3);
            Vector3D v1 = new Vector3D(2, 2, 3);


            //Act
            bool result = (v0 != v1);

            //Assert
            Assert.IsTrue(result);
        }


    }
}