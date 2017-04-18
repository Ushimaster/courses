namespace Courses._20483.UI
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class Int32ValueConverter: IValueConverter

    {
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            return ConvertBothWays( value );
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            return ConvertBothWays( value );
        }

        private static object ConvertBothWays( object value )
        {
            int result;
            string s = value.ToString();

            if( int.TryParse( s, out result ) )
            {
                return result;
            }

            return 0;
        }
    }
}
