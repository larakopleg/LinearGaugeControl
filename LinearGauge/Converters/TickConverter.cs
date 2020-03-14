using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LinearGauge
{
    class TickConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(values.Length == 2 && values[0] is int && values[1] is int)
            {
                int min = (int)values[0];
                int max = (int)values[1];
                int size = max - min;
                Console.WriteLine("size= " + size);

                if (size <= 50)
                {
                    Console.WriteLine("na 5");
                    return 5.0;
                }
                else
                {
                    Console.WriteLine("na 10");
                    return 10.0;
                }
            }

            return 0;

        }
        
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
