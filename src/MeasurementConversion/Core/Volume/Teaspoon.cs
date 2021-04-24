using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public class Teaspoon : BaseVolume
    {
        public Teaspoon(decimal teaspoons)
            : base()
        {
            this.unitOfMeasureAbbreviated = "t";
            this.Amount = teaspoons;
        }

        public override decimal ToMilliliters()
        {
            return Math.Round(this.Amount * 4.92892159m, 2);
        }

        public override decimal ToFluidOunces()
        {
            return Math.Round(this.Amount * 0.166666667m, 4);
        }

        public override decimal ToTablespoons()
        {
            return Math.Round(this.Amount / 3m, 4);
        }

        public override decimal ToTeaspoons()
        {
            return this.Amount;
        }

        public override decimal ToCups()
        {
            return Math.Round(this.Amount / 48m, 4);
        }

        public override decimal ToQuarts()
        {
            return Math.Round(this.Amount * 0.00520833333m, 4);
        }

        public override decimal ToPints()
        {
            return Math.Round(this.Amount * 0.0104166667m, 4);
        }

        public override decimal ToGallons()
        {
            return Math.Round(this.Amount * 0.00130208333m, 4);
        }
    }
}
