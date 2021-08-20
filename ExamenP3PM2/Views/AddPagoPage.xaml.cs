using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenP3PM2.Models;
using ExamenP3PM2.ViewModels;

namespace ExamenP3PM2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPagoPage : ContentPage
    {
        public Pagos Pagos { get; set; }
        public AddPagoPage()
        {
            InitializeComponent();
            BindingContext = new AddPagoViewModel();
        }
        public AddPagoPage(Pagos pagos)
        {
            InitializeComponent();
            BindingContext = new AddPagoViewModel();

            if (pagos != null)
            {
                ((AddPagoViewModel)BindingContext).Pagos = pagos;
            }
        }
    }
}