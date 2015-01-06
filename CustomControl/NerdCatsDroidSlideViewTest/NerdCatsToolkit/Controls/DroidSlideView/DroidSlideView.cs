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
    public class DroidSlideView: ItemsControl
    {
        public DroidSlideView()
        {
            DefaultStyleKey = typeof(DroidSlideView);
            Debug.WriteLine(this.Items.Count.ToString());

           
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            Debug.WriteLine(this.Items.Count.ToString());
            
        }

       

        



    }
}
