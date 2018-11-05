using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Selector
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class todoPage : ContentPage
    {

        public todoPage()
        {
            InitializeComponent();
        }

        public string todo;

        public todoPage (Person todo)
        {
            this.todo = todo.Name;
        }

        
	}
}