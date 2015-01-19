using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace NerdCatsToolkit.Controls.HubTileExt
{
    public class TileSizeToHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double baseHeight = 0;

            switch ((TileSize)value)
            {
                case TileSize.Default:
                    baseHeight = 173;
                    break;

                case TileSize.Small:
                    baseHeight = 99;
                    break;

                case TileSize.Medium:
                    baseHeight = 210;
                    break;

                case TileSize.Large:
                    baseHeight = 210;
                    break;
            }

            double multiplier;

            if (parameter == null || double.TryParse(parameter.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out multiplier) == false)
            {
                multiplier = 1;
            }

            return baseHeight * multiplier;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
