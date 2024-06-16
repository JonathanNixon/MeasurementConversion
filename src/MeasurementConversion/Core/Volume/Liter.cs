using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public sealed class Liter : MetricVolume, IVolume
    {
        public Liter(decimal liters)
            : base()
        {
            this.unitOfMeasureAbbreviated = "L";
            this.Amount = liters;
        }

        public override decimal ToMilliliters()
        {
            return this.Amount / 1000;
        }

        public override decimal ToLiters()
        {
            return (ToMilliliters() / 1000);
        }

        public override decimal ToFluidOunces()
        {
            return new Milliliter(this.ToMilliliters()).ToFluidOunces();
        }

        public override decimal ToTablespoons()
        {
            return new Milliliter(this.ToMilliliters()).ToTablespoons();
        }

        public override decimal ToTeaspoons()
        {
            return new Milliliter(this.ToMilliliters()).ToTeaspoons();
        }

        public override decimal ToCups()
        {
            return new Milliliter(this.ToMilliliters()).ToCups();
        }

        public override decimal ToQuarts()
        {
            return new Milliliter(this.ToMilliliters()).ToQuarts();
        }

        public override decimal ToPints()
        {
            return new Milliliter(this.ToMilliliters()).ToPints();
        }

        public override decimal ToGallons()
        {
            return new Milliliter(this.ToMilliliters()).ToGallons();
        }
    }
}
