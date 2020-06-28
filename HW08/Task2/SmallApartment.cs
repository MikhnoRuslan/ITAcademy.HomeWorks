using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class SmallApartment : House
    {
        private const int _AreaSmallApartment = 50;

        public SmallApartment()
        {
            Area = _AreaSmallApartment;
        }
    }
}
