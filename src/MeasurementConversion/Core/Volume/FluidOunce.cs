using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public sealed class FluidOunce : BaseVolume, IVolume
    {

        public FluidOunce(decimal fluidOunces)
            : base()
        {
            this.unitOfMeasureAbbreviated = "fluid oz.";
            this.Amount = fluidOunces;
        }

        public override decimal ToMilliliters()
        {
            return Math.Round(this.Amount * 29.5735296m, 2);
        }

        public override decimal ToFluidOunces()
        {
            return this.Amount;
        }

        public override decimal ToTablespoons()
        {
            return this.Amount * 2m;
        }

        public override decimal ToTeaspoons()
        {
            return this.Amount * 6m;
        }

        public override decimal ToCups()
        {
            return Math.Round(this.Amount * 0.125m, 2);
        }

        public override decimal ToQuarts()
        {
            return Math.Round(this.Amount * 0.03125m, 2);
        }

        public override decimal ToPints()
        {
            return Math.Round(this.Amount * 0.0625m);
        }

        public override decimal ToGallons()
        {
            return Math.Round(this.Amount * 0.0078125m, 2);
        }
    }
}