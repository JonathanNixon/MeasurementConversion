using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Mass
{
    public class Ounce : BaseMass
    {
        public Ounce(decimal ounces)
        {
            this.Amount = ounces;
            this.unitOfMeasureAbbreviated = "oz.";
        }
        public override decimal ToGrams()
        {
            return Math.Round(this.Amount * 28.3495231m, 2);
        }

        public override decimal ToOunces()
        {
            return this.Amount;
        }

        public override decimal ToPounds()
        {
            return this.Amount * 0.0625m;
        }
    }
}
