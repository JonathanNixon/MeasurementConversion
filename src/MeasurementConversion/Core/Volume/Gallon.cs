using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public sealed class Gallon : BaseVolume, IVolume
    {
        public Gallon(decimal gallons)
            : base()
        {
            this.unitOfMeasureAbbreviated = "gal.";
            this.Amount = gallons;
        }

        public override decimal ToMilliliters()
        {
            return System.Math.Round(this.Amount * 3785.41178m, 2);
        }

        public override decimal ToFluidOunces()
        {
            return this.Amount * 128m;
        }

        public override decimal ToTablespoons()
        {
            return this.Amount * 256m;
        }

        public override decimal ToTeaspoons()
        {
            return this.Amount * 768m;
        }

        public override decimal ToCups()
        {
            return this.Amount * 16m;
        }

        public override decimal ToQuarts()
        {
            return this.Amount * 4m;
        }

        public override decimal ToPints()
        {
            return this.Amount * 8m;
        }

        public override decimal ToGallons()
        {
            return this.Amount;
        }
    }
}
