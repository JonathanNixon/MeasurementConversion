using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public class Cup : BaseVolume
    {
        public Cup(decimal cups)
            : base()
        {
            this.unitOfMeasureAbbreviated = "C";
            this.Amount = cups;
        }

        public override decimal ToMilliliters()
        {
            return Math.Round(this.Amount * 236.588237m, 2);
        }

        public override decimal ToFluidOunces()
        {
            return this.Amount * 8;
        }

        public override decimal ToTablespoons()
        {
            return this.Amount * 16m;
        }

        public override decimal ToTeaspoons()
        {
            return this.Amount * 48m;
        }

        public override decimal ToCups()
        {
            return this.Amount;
        }

        public override decimal ToQuarts()
        {
            return this.Amount / 4m;
        }

        public override decimal ToPints()
        {
            return this.Amount / 2m;
        }

        public override decimal ToGallons()
        {
            return this.Amount * 0.0625m;
        }
    }
}
