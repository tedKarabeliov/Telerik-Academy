using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace School
{
    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Such student does not exist")]
        public void RemoveStudentThrowsException()
        {
            Course course = new Course();
            course.RemoveStudent(new Student("Pesho"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Attempt to add a student when maximum amount of students in a course is reached")]
        public void StudentAddThrowsException()
        {
            Course course = new Course();
            for (int i = 0; i < 31; i++)
            {
                course.AddStudent(new Student("Pesho"));
            }
        }

        [TestMethod]
        public void StudentGetThrowsException()
        {
            Course course = new Course();
            var peshoStudent = new Student("Pesho");
            var goshoStudent = new Student("Gosho");
            course.AddStudent(peshoStudent);
            course.AddStudent(goshoStudent);
            Assert.AreEqual(peshoStudent.Name + " " + goshoStudent.Name, course.ToString(), "Expected students not showed");
        }
    }
}
