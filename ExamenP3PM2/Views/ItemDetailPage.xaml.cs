using ExamenP3PM2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ExamenP3PM2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}