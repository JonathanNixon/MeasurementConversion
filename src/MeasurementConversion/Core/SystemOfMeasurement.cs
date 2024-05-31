using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Measurement.Core
{
    public class SystemOfMeasurement : ISystemOfMeasurement
    {
        private bool isUSCustomaryUnits;

        public bool IsInternationalSystemOfMeasure()
        {
            return !isUSCustomaryUnits;
        }

        public bool IsUSCustomaryUnits()
        {
            return isUSCustomaryUnits;
        }

        public SystemOfMeasurement(bool isUSCustomaryUnits)
        {
            this.isUSCustomaryUnits=isUSCustomaryUnits;
        }
    }
}