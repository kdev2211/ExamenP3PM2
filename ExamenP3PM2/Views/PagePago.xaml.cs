using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenP3PM2.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenP3PM2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePago : ContentPage
    {
        pagoViewModel PagoViewModel;
        public PagePago()
        {
            InitializeComponent();
            BindingContext = PagoViewModel = new pagoViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            PagoViewModel.OnAppearing();
        }

    }
    }

