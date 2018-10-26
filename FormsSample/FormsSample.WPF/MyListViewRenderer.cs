using FormsSample;
using FormsSample.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

[assembly: ExportRenderer(typeof(MyListView), typeof(MyListViewRenderer))]
namespace FormsSample.WPF
{
    public class MyListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);


            (Element as MyListView).UnselectedEvent += () =>
            {
                Control.UnselectAll();
            };
        }
    }
}
