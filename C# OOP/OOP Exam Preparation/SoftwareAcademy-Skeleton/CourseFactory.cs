namespace SoftwareAcademy
{
    using System;

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            Teacher teacher = new Teacher(name);
            return teacher;
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            ILocalCourse localCourse = new LocalCourse(name, teacher, lab);
            return localCourse;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse offsiteCourse = new OffsiteCourse(name, teacher, town);
            return offsiteCourse;
        }
    }
}
