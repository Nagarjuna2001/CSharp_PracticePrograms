using System;
using System.Collections.Generic;
using System.Text;

namespace InternalProtectedInternalModifier
{
    public class InternalProtectedInternalModifierExample
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Student Id : " + student.StudentId);
            Console.WriteLine("School name : "+ student.StudentSchoolName);
            Console.WriteLine("Student Age : " + student.StudentAge);
        }
    }
}
