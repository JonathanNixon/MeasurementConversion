using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Weight
{
    public class Gram : MetricWeight
    {
        public Gram(decimal grams)
        {
            this.Amount = grams;
            this.unitOfMeasureAbbreviated = "g";
        }

        public override decimal ToGrams()
        {
            return this.Amount;
        }

        public override decimal ToOunces()
        {
            return System.Math.Round(this.Amount * 0.0352739619m, 2);
        }

        public override decimal ToPounds()
        {
            return System.Math.Round(this.Amount * 0.00220462262m, 2);
        }
    }
}
