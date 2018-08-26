using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace Phoneword.MVVM_Cross.Core.Converters
{
    public class CharToNumberConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        //protected override ViewModelPropertyType ConvertBack(ViewPropertyType value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    throw new NotImplementedException();
        //}
    }
}