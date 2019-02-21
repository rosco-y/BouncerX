using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace BouncerX
{
    class OccasionConverter : IValueConverter
    {
        /// <summary>
        /// Convert qa databound object into a value to be displayed.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="parameter"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public object Convert(object value,
            object parameter,
            string language)
        {
            if (value is Occasion)
            {
                var occastion = value as Occasion;
                var ui_command = parameter as string;
                if (ui_command == "number of attendants")
                    return $"{occastion.AttendanceCount} Attendants";
            }
            return "Uknown number of Attendants";
        }

        
        /// <summary>
        /// Convert from bound value to displayable value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public object Convert(object value, 
            Type targetType, 
            object parameter, 
            string language)
        {
            if (value is Occasion)
            {
                var occasion = value as Occasion;
                var ui_command = parameter as string;
                if (ui_command == "number of attendants")
                    return $"{occasion.AttendanceCount} Attendants";
            }
            return "Uknown number of attendants";
        }
        /// <summary>
        /// Saving Binding data back to databound object.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public object ConvertBack(object value,
            Type targetType,
            object parameter,
            string language)
        {
            throw new NotImplementedException();
        }

    }
}
    
