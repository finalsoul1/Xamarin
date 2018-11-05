using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewp168
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //var listView = new ListView { };
            //listView.ItemsSource = Emp.Emps;

            //Content = new StackLayout
            //{
            //    Children = { listView }
            //};

            listView.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                var emp = e.SelectedItem as Emp;

                var nextPage = new NextPage();
                nextPage.BindingContext = emp;
                await Navigation.PushAsync(nextPage);
            };
        }
        
    }
}
