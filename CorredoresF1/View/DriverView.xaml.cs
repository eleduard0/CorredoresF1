using CorredoresF1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorredoresF1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriverView : ContentPage
    {
        public DriverView()
        {
            InitializeComponent();
            BindingContext = new DriverViewModel(Navigation);
        }
    }
}