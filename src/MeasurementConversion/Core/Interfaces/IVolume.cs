using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Interfaces
{
    public interface IVolume : IMeasurement
    {
        decimal ToMilliliters();

        decimal ToFluidOunces();

        decimal ToTablespoons();

        decimal ToTeaspoons();

        decimal ToCups();

        decimal ToQuarts();

        decimal ToPints();

        decimal ToGallons();

        IVolume ToOptimal();
    }
}
