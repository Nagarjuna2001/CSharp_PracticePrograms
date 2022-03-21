using System;
using InternalProtectedInternalModifier;

namespace Internal_ProtectedInternalAccessModifier
{
    public class AccessModifiersExample : Student
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Student Id : " + student.StudentId);

            //The below line generates compiler error as it is an internal member which cannot be accessed outside its containing assembly
            //Console.WriteLine("School name : " + student.StudentSchoolName);

            AccessModifiersExample example = new AccessModifiersExample();
            Console.WriteLine("Student Age : " + example.StudentAge);
            
        }
    }
}
