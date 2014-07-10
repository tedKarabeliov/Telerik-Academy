using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Students
{
    /*
    1. Define a class Student, which contains data about a student –
    first, middle and last name, SSN, permanent address,
    mobile phone e-mail, course, specialty, university,
    faculty. Use an enumeration for the specialties, universities
    and faculties. Override the standard methods, inherited by
    System.Object: Equals(), ToString(), GetHashCode() and
    operators == and !=.

    2. Add implementations of the ICloneable interface. The Clone()
    method should deeply copy all object's fields into a new object
    of type Student.

    3. Implement the  IComparable<Student> interface to compare students
    by names (as first criteria, in lexicographic order) and by social security
    number (as second criteria, in increasing order).
    */

    public class Student : ICloneable, IComparable<Student>
    {
        public enum SpecialtyType
        {
            Mathematics,
            Literature,
            Biology
        }
        public enum UniversityType
        {
            SofiaUnivercity,
            UnivercityOfNationalAndWorldEconomy
        }
        public enum FacultyType
        {
            One,
            Two
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Adress { get; set; }
        public string MobilePhone { get; set; }
        public string Course { get; set; }
        public SpecialtyType Specialty { get; set; }
        public UniversityType Univercity { get; set; }
        public FacultyType Faculty { get; set; }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (this.FirstName == student.FirstName &&
                this.MiddleName == student.MiddleName &&
                this.LastName == student.LastName)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.MiddleName + " " + this.LastName;
        }
        public override int GetHashCode()
        {
            Console.WriteLine("This method is inherited");
            return base.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }
        public static bool operator !=(Student student1, Student student2)
        {
            return (!student1.Equals(student2));
        }

        public object Clone()
        {
            Student clone = new Student
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                SSN = this.SSN,
                Adress = this.Adress,
                MobilePhone = this.MobilePhone,
                Course = this.Course,
                Specialty = this.Specialty,
                Univercity = this.Univercity,
                Faculty = this.Faculty
            };
            
            return clone;
        }

        public int CompareTo(Student student)
        {
            string thisFullName = this.FirstName + this.MiddleName + this.LastName;
            string studentFullName = student.FirstName + student.MiddleName + student.LastName;

            int comparedFullnames = String.Compare(thisFullName,studentFullName);
            if (comparedFullnames == 1)
            {
                return 1;
            }
            else if (comparedFullnames == -1)
            {
                return -1;
            }
            else
            {
                if (this.SSN > student.SSN)
                {
                    return 1;
                }
                else if (this.SSN < student.SSN)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
