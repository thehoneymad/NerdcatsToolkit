using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace NerdCatsToolkit.Controls.HubTileExt
{
    /// <summary>
    /// Returns the Hub tile width corresponding to a tile size.
    /// </summary>
    public class TileSizeToWidthConverter : IValueConverter
    {
        /// <summary>
        /// Converts from a tile size to the corresponding width.
        /// </summary>

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double baseWidth = 0;

            switch ((TileSize)value)
            {
                case TileSize.Default:
                    baseWidth = 173;
                    break;

                case TileSize.Small:
                    baseWidth = 99;
                    break;

                case TileSize.Medium:
                    baseWidth = 210;
                    break;

                case TileSize.Large:
                    baseWidth = 432;
                    break;
            }

            double multiplier;

            if (parameter == null || double.TryParse(parameter.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out multiplier) == false)
            {
                multiplier = 1;
            }

            return baseWidth * multiplier;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
