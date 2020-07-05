using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            // MotorcycleTwo motoTwo = new MotorcycleTwo(); // impossible because class MotorcycleTwo is internal
            SportBike sportBike = new SportBike();
            SportBikeTwo sportBikeTwo = new SportBikeTwo(); // i can create an object but the class is empty

            moto.MaxSpeedPublic();
            // moto.MaxSpeedProtected(); // cant because is protected
            // moto.MaxSpeedInternal(); // cant because its a new assembly
            // moto.MaxSpeedProtectedInternal(); // cant because its new assemble and method is protected
            // moto.MaxSpeedPrivate(); // cant because is private
        }
    }
}
