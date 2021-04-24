using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public class Quart : BaseVolume
    {
        public Quart(decimal quarts)
        {
            this.unitOfMeasureAbbreviated = "qt.";
            this.Amount = quarts;
        }

        public override decimal ToMilliliters()
        {
            return System.Math.Round(this.Amount * 946.352946m, 2);
        }

        public override decimal ToFluidOunces()
        {
            return this.Amount * 32m;
        }

        public override decimal ToTablespoons()
        {
            return this.Amount * 64m;
        }

        public override decimal ToTeaspoons()
        {
            return this.Amount * 192m;
        }

        public override decimal ToCups()
        {
            return this.Amount * 4m;
        }

        public override decimal ToQuarts()
        {
            return this.Amount;
        }

        public override decimal ToPints()
        {
            return this.Amount * 2m;
        }

        public override decimal ToGallons()
        {
            return this.Amount / 4m;
        }
    }
}