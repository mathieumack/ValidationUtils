using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationUtils.Methods;

namespace ValidationUtils.Tests.Unit
{
    [TestClass]
    public class ParamsValidatorTests
    {
        [TestMethod]
        public void CheckIfAnyNull_Valid()
        {
            ParamsValidator.CheckIfAnyNull<ArgumentNullException>("toto", new { Toto = "Hello" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckIfAnyNull_WithNull()
        {
            ParamsValidator.CheckIfAnyNull<ArgumentNullException>("toto", null, new { Toto = "Hello" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckIfAnyNull_WithNull2()
        {
            ParamsValidator.CheckIfAnyNull<ArgumentNullException>("toto", null);
        }

        [TestMethod]
        public void CheckIfAnyNull_Empty()
        {
            ParamsValidator.CheckIfAnyNull<ArgumentNullException>();
        }
    }
}
