using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void CheckStudentNameIsCorrect()
        {
            Student student = new Student("Pesho");
            Assert.AreEqual("Pesho", student.Name, "Student's name is not assigned");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Name is null or empty")]
        public void StudentNameThrowsException()
        {
            Student student = new Student("Pesho");
            student.Name = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Student number must be between 10000 and 99999")]
        public void StudentNumberThrowsException()
        {
            Student student = new Student("Pesho");
            student.Number = 5;
        }
    }
}
