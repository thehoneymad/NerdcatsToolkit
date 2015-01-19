using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace NerdCatsToolkit.Controls.HubTileExt
{
    internal class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((bool)value ^ (bool)parameter)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
