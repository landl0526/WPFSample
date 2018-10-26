using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FormsSample
{
    public class MyListView : ListView
    {

        public delegate void UnSelectedDelegate();
        public event UnSelectedDelegate UnselectedEvent;

        public void UnSelectedAll()
        {
            UnselectedEvent?.Invoke();
        }
    }
}
