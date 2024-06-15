using Jdn.Measurement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdn.Measurement.Core.Weight
{
    public static class WeightFactory
    {
        public static IWeight Pounds(decimal pounds)
        {
            return new Pound(pounds);
        }

        public static IWeight Ounces(decimal ounces)
        {
            return new Ounce(ounces);
        }

        public static IWeight Grams(decimal grams)
        {
            return new Gram(grams);
        }
    }
}