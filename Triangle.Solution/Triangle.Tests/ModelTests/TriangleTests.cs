using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void ValidateTriangle_ValidSides_Valid()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual("valid", testTriangle.ValidateTriangle(3,4,5));
        }

        [TestMethod]
        public void ValidateTriangle_ValidSides_Invalid()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual("invalid", testTriangle.ValidateTriangle(3,-4,0));
        }
    }
}
