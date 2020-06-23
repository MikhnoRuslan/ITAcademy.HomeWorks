using System;
using System.Collections.Generic;
using System.Text;
using AssemblyOne;

namespace AssemblyTwo
{
    public class SportBike : Motorcycle // because class Motorcycle is public
    {
        public void Speed()
        {
            MaxSpeedProtectedInternal();
            MaxSpeedProtected();
            MaxSpeedPublic();
        }
    }
}
