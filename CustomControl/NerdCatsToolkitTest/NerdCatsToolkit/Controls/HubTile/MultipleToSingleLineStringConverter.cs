using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace NerdCatsToolkit.Controls.HubTileExt
{
    internal class MultipleToSingleLineStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string multiline = value as string;

            if (string.IsNullOrEmpty(multiline))
                return string.Empty;

            return multiline.Replace(Environment.NewLine, " ");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
