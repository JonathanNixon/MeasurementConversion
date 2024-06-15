using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public sealed class Pint : USCustomaryVolume, IVolume
    {
        public Pint(decimal pints)
            : base()
        {
            this.unitOfMeasureAbbreviated = "pt.";
            this.Amount = pints;
        }

        public override decimal ToMilliliters()
        {
            return Math.Round(this.Amount * 473.176473m, 2);
        }

        public override decimal ToFluidOunces()
        {
            return this.Amount * 16m;
        }

        public override decimal ToTablespoons()
        {
            return this.Amount * 32m;
        }

        public override decimal ToTeaspoons()
        {
            return this.Amount * 96m;
        }

        public override decimal ToCups()
        {
            return this.Amount * 2m;
        }

        public override decimal ToQuarts()
        {
            return this.Amount / 2m;
        }

        public override decimal ToPints()
        {
            return this.Amount;
        }

        public override decimal ToGallons()
        {
            return Math.Round(this.Amount * 0.125m);
        }
    }
}
