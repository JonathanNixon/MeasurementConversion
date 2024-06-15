using Jdn.Measurement.Core.Interfaces;
using Jdn.Measurement.Core.Volume;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Weight
{
    public abstract class BaseWeight : IWeight
    {
        protected string unitOfMeasure;
        protected string unitOfMeasureAbbreviated;
        protected string unitOfMeasurePlural;
        private ISystemOfMeasurement systemOfMeasurement;

        protected int numberOfDecimalPlaces = 2;

        public BaseWeight(ISystemOfMeasurement systemOfMeasurement)
        {
            this.systemOfMeasurement = systemOfMeasurement;
            unitOfMeasure = this.GetType().Name;
            unitOfMeasurePlural = $"{unitOfMeasure}s";
            unitOfMeasureAbbreviated = unitOfMeasurePlural.Substring(0, 3);
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

        public IWeight ToOptimal()
        {
            var pounds = ToPounds();
            if (pounds >= 1)
            {
                return new Pound(pounds);
            }

            return new Ounce(ToOunces());
        }

        private IWeight ToOptimalUSCustomaryUnits()
        {
            var pounds = ToPounds();
            if (pounds >= 1)
            {
                return new Pound(pounds);
            }

            return new Ounce(ToOunces());
        }

        private IWeight ToOptimalMetric()
        {
            return new Gram(ToGrams());
        }
    }
}
