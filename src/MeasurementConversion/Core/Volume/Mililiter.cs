using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public sealed class Milliliter : MetricVolume, IVolume
    {
        public Milliliter(decimal mililiters)
            : base()
        {
            this.unitOfMeasureAbbreviated = "mL";
            this.Amount = mililiters;
        }

        public override decimal ToMilliliters()
        {
            return this.Amount;
        }

        public override decimal ToFluidOunces()
        {
            return this.Amount * 0.0338140227m;
        }

        public override decimal ToTablespoons()
        {
            return this.Amount * 0.0676280454m;
        }

        public override decimal ToTeaspoons()
        {
            return this.Amount * 0.202884136m;
        }

        public override decimal ToCups()
        {
            return this.Amount * 0.00422675284m;
        }

        public override decimal ToQuarts()
        {
            return this.Amount * 0.00105668821m;
        }

        public override decimal ToPints()
        {
            return this.Amount * 0.00211337642m;
        }

        public override decimal ToGallons()
        {
            return this.Amount * 0.000264172052m;
        }
    }
}
