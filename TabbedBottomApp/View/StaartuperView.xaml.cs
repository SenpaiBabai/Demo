using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedBottomApp.Model;
using TabbedBottomApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedBottomApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaartuperView : ContentPage
    {
        SturtuperViewModel vm;
        public StaartuperView()
        {
            InitializeComponent();
            vm = new SturtuperViewModel();
            // listStartupers.ItemsSource = vm.Startupers;
            BindingContext = vm;
        }
    }
}