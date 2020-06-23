using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            moto.MaxSpeedPublic();
            // moto.MaxSpeedProtected; // because protected/ 
            moto.MaxSpeedInternal();
            moto.MaxSpeedProtectedInternal();
            // moto.MaxSpeedPrivate(); // cant because is private
            // moto.MaxSpeedPrivateProtected(); 
        }
    }
}
