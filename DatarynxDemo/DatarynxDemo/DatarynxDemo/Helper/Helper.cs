using DatarynxDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DatarynxDemo
{
    public class DynamicToPathValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;
            ExpandoObject busniessObject = JsonConvert.DeserializeObject<ExpandoObject>(value.ToString());
            var jsonList = busniessObject.ToList();
            if (parameter.Equals("Value1"))
                return jsonList[0].Value;
            if (parameter.Equals("Value2"))
                return jsonList[1].Value;
            if (parameter.Equals("Value3"))
                return jsonList[2].Value;
            if (parameter.Equals("Value4"))
                return jsonList[3].Value;
            if (parameter.Equals("Value5"))
                return jsonList[4].Value;
            if (parameter.Equals("Value6"))
            {
                if (jsonList[5].Value.ToString() == "In-Progress")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;
            ExpandoObject busniessObject = JsonConvert.DeserializeObject<ExpandoObject>(value.ToString());
            var jsonList = busniessObject.ToList();
            if (parameter.Equals("Value6"))
                if (jsonList[5].Value.ToString() == "In-Progress")
                {
                    return Color.Green ;
                }
                else
                {
                    return Color.Gray;
                }
            return Color.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

}
