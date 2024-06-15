using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Weight
{
    public class Pound : USCustomaryWeight
    {
        public Pound(decimal pounds)
            : base()
        {
            this.unitOfMeasureAbbreviated = "lb.";
            this.Amount = pounds;
        }

        public override decimal ToGrams()
        {
            return Math.Round(this.Amount * 453.59237m, 2);
        }

        public override decimal ToOunces()
        {
            return this.Amount * 16m;
        }

        public override decimal ToPounds()
        {
            return this.Amount;
        }
    }
}