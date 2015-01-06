using System;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace NerdCatsToolkit.Controls
{
     [TemplatePart(Name = HeaderBarName, Type = typeof(ListBox))]
    public class DroidSlideView: ItemsControl
    {

        private const string HeaderBarName = "ImageBar";

        private ListBox _headerListBox;
        public DroidSlideView()
        {
            DefaultStyleKey = typeof(DroidSlideView);
            

           
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _headerListBox = GetTemplateChild(HeaderBarName) as ListBox;
            _headerListBox.CacheMode = new BitmapCache();

            if(this.Items.Count>0)
            {

            }
        }

        

       

        



    }
}
