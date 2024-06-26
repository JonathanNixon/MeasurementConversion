﻿using Jdn.Measurement.Core.Interfaces;
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

        private ISystemOfMeasurement systemOfMeasurement;

        protected int numberOfDecimalPlaces = 2;

        public BaseVolume(ISystemOfMeasurement systemOfMeasurement)
        {
            this.systemOfMeasurement = systemOfMeasurement;
            unitOfMeasure = this.GetType().Name;
            unitOfMeasurePlural = $"{unitOfMeasure}s";
            unitOfMeasureAbbreviated = unitOfMeasurePlural.Substring(0, 3);
        }

        public IVolume ToOptimal()
        {
            if (systemOfMeasurement.IsUSCustomaryUnits())
            {
                return ToOptimalUSCustomaryUnits();
            }
           
            return ToOptimalMetric();           
        }

        private IVolume ToOptimalUSCustomaryUnits()
        {
            if (ToGallons() >= 1) return new Gallon(ToGallons());
            if (ToCups() >= 1) return new Cup(ToCups());
            if (ToQuarts() >= 1) return new Quart(ToQuarts());
            if (ToPints() >= 1) return new Pint(ToPints());
            if (ToTablespoons() >= 1) return new Tablespoon(ToTablespoons());
            
            return new Teaspoon(ToTeaspoons());
        }

        private IVolume ToOptimalMetric()
        {
            if (ToMilliliters() >= 1) return new Milliliter(ToMilliliters());

            return new Milliliter(ToMilliliters());
        }

        public abstract decimal ToMilliliters();

        public abstract decimal ToFluidOunces();

        public abstract decimal ToTablespoons();

        public abstract decimal ToTeaspoons();

        public abstract decimal ToCups();

        public abstract decimal ToQuarts();

        public abstract decimal ToPints();

        public abstract decimal ToGallons();

        public abstract decimal ToLiters();

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
