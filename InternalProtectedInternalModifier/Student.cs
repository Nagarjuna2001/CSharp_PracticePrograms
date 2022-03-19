using System;

namespace InternalProtectedInternalModifier
{
    public class Student
    {
        public Student() { }

        public int StudentId = 102;

        internal string StudentSchoolName = "DPS";

        protected internal int StudentAge = 16;
    }
}
