using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Mass
{
    public static class MassFactory
    {
        public static IMass Pounds(decimal pounds)
        {
            return new Pound(pounds);
        }

        public static IMass Ounces(decimal ounces)
        {
            return new Ounce(ounces);
        }

        public static IMass Grams(decimal grams)
        {
            return new Gram(grams);
        }
    }
}
