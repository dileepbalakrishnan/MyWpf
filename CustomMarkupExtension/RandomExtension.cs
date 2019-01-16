using System;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace CustomMarkupExtension
{
    public class RandomExtension : MarkupExtension
    {
        private readonly int _from;
        private readonly Random _rnd = new Random();
        private readonly int _to;

        public RandomExtension(int from, int to)
        {
            _from = from;
            _to = to;
        }

        public RandomExtension(int to) : this(0, to)
        {
        }

        public bool UseFractions { get; set; }
        /// <summary>
        /// Returns a random number after converting it into a suitable type.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var value = UseFractions
                ? _rnd.NextDouble() * (_to - _from) + _from
                : _rnd.Next(_from, _to);
            Type targetType = null;
            if (serviceProvider != null)
                if (serviceProvider.GetService(typeof(IProvideValueTarget)) is IProvideValueTarget target)
                    switch (target.TargetProperty)
                    {
                        case PropertyInfo clrProp:
                            targetType = clrProp.PropertyType;
                            break;
                        case DependencyProperty dp:
                            targetType = dp.PropertyType;
                            break;
                    }
            return targetType != null
                ? Convert.ChangeType(value, targetType)
                : value.ToString(CultureInfo.InvariantCulture);
        }
    }
}