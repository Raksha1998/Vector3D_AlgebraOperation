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
    }
}