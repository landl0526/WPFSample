using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsSample
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> list = new ObservableCollection<string>();
        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                list.Add("name" + i);
            }
            MyListView.ItemsSource = list;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MyListView.UnSelectedAll();

            ObservableCollection<string> myList = new ObservableCollection<string>();
            for (int i = 100; i < 110; i++)
            {
                myList.Add("name" + i);
            }

            MyListView.ItemsSource = myList;

        }
    }
}
