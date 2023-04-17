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
    }
}