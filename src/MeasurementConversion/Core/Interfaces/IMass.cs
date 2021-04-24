using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Interfaces
{
    public interface IMass : IMeasurement
    {
        decimal ToGrams();

        decimal ToOunces();

        decimal ToPounds();
    }
}
