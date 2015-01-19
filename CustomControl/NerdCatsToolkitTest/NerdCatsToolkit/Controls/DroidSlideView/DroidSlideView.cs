using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace NerdCatsToolkit.Controls
{
    [TemplatePart(Name = HeaderBarName, Type = typeof(ListBox))]
    public class DroidSlideView : ItemsControl
    {

        private const string HeaderBarName = "ImageBar";

        private ListBox _headerListBox;
        public DroidSlideView()
        {
            DefaultStyleKey = typeof(DroidSlideView);



        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _headerListBox = GetTemplateChild(HeaderBarName) as ListBox;
            _headerListBox.CacheMode = new BitmapCache();

            if (this.Items.Count > 0)
            {

            }
        }


    }
}

