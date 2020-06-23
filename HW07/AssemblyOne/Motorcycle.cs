using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        string _brand;
        string _model;
        int _yearOfIssue;

        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfIssue { get; set; }

        public void MaxSpeedPublic()
        {
            MaxSpeedProtected();
        }

        protected void MaxSpeedProtected()
        {
            Brand = _brand;
        }

        internal void MaxSpeedInternal()
        {
            MaxSpeedProtectedInternal();
        }

        protected internal void MaxSpeedProtectedInternal()
        {
            MaxSpeedPrivate();
        }

        private void MaxSpeedPrivate()
        {
        }

        private protected void MaxSpeedPrivateProtected()
        {
        }
    }
}
