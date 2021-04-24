using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Volume
{
    public static class VolumeFactory
    {
        public static IVolume Teaspoons(decimal teaspoons)
        {
            return new Teaspoon(teaspoons);
        }

        public static IVolume Tablespoons(decimal tablespoons)
        {
            return new Tablespoon(tablespoons);
        }

        public static IVolume Cups(decimal cups)
        {
            return new Cup(cups);
        }

        public static IVolume Mililiters(decimal mililiters)
        {
            return new Milliliter(mililiters);
        }

        public static IVolume Quarts(decimal quarts)
        {
            return new Quart(quarts);
        }

        public static IVolume Pints(decimal pints)
        {
            return new Pint(pints);
        }

        public static IVolume Gallons(decimal gallons)
        {
            return new Gallon(gallons);
        }

        public static IVolume FluidOunces(decimal fluidOunces)
        {
            return new FluidOunce(fluidOunces);
        }
    }
}
