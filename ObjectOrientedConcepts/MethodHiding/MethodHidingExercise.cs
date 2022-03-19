using System;

namespace MethodHiding
{
    public class MethodHidingExercise
    {
        static void Main(string[] args)
        {
            Base baseReferenceTypeObject = new Derived();
            baseReferenceTypeObject.printToConsole();

            Derived derivedReferenceTypeObject = new Derived();
            derivedReferenceTypeObject.printToConsole();

        }
    }
}
 