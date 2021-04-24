using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Mass
{
    public abstract class BaseMass : IMass
    {
        protected string unitOfMeasure;
        protected string unitOfMeasureAbbreviated;
        protected string unitOfMeasurePlural;

        protected int numberOfDecimalPlaces = 2;

        public BaseMass()
        {
            unitOfMeasure = this.GetType().Name;
            unitOfMeasurePlural = $"{unitOfMeasure}s";
        }

        public decimal Amount { get; set; }

        public string UnitOfMeasure
        {
            get { return unitOfMeasure; }
        }

        public string AbbreviatedDisplayString => $"{this.Amount} {this.unitOfMeasureAbbreviated}";

        public string DisplayString => this.Amount > 1.0m ? $"{this.Amount} {this.unitOfMeasurePlural}" : $"{this.Amount} {this.unitOfMeasure}";

        public IMeasurement MultiplyBy(decimal value)
        {
            var copy = this.MemberwiseClone() as IMeasurement;
            copy.Amount *= value;
            return copy;
        }

        public abstract decimal ToGrams();

        public abstract decimal ToOunces();

        public abstract decimal ToPounds();
    }
}
