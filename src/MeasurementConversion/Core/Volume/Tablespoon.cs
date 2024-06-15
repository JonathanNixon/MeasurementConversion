using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public sealed class Tablespoon : USCustomaryVolume, IVolume
    {
        public Tablespoon(decimal tablespoons)
            : base()
        {
            this.unitOfMeasureAbbreviated = "T";
            this.Amount = tablespoons;
        }

        public override decimal ToMilliliters()
        {
            return System.Math.Round(this.Amount * 14.7867648m, 2);
        }

        public override decimal ToFluidOunces()
        {
            return this.Amount / 2;
        }

        public override decimal ToTablespoons()
        {
            return this.Amount;
        }

        public override decimal ToTeaspoons()
        {
            return this.Amount * 3;
        }

        public override decimal ToCups()
        {
            return System.Math.Round(this.Amount * 0.0625m, 2);
        }

        public override decimal ToQuarts()
        {
            return this.Amount * 0.015625m;
        }

        public override decimal ToPints()
        {
            return this.Amount * 0.03125m;
        }

        public override decimal ToGallons()
        {
            return this.Amount * 0.00390625m;
        }
    }
}
