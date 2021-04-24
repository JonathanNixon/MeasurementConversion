using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public abstract class BaseVolume : IVolume
    {
        protected string unitOfMeasure;
        protected string unitOfMeasureAbbreviated;
        protected string unitOfMeasurePlural;

        protected int numberOfDecimalPlaces = 2;

        public BaseVolume()
        {
            unitOfMeasure = this.GetType().Name;
            unitOfMeasurePlural = $"{unitOfMeasure}s";
        }

        public abstract decimal ToMilliliters();

        public abstract decimal ToFluidOunces();

        public abstract decimal ToTablespoons();

        public abstract decimal ToTeaspoons();

        public abstract decimal ToCups();

        public abstract decimal ToQuarts();

        public abstract decimal ToPints();

        public abstract decimal ToGallons();

        public decimal Amount { get; set; }

        public string UnitOfMeasure => this.unitOfMeasure;

        public string AbbreviatedDisplayString => $"{this.Amount} {this.unitOfMeasureAbbreviated}";

        public string DisplayString => this.Amount > 1.0m ? $"{this.Amount} {this.unitOfMeasurePlural}" : $"{this.Amount} {this.unitOfMeasure}";

        public IMeasurement MultiplyBy(decimal value)
        {
            var copy = this.MemberwiseClone() as IMeasurement;
            copy.Amount *= value;
            return copy;
        }
    }
}
