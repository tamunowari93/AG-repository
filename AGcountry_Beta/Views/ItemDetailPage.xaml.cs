using System.ComponentModel;
using Xamarin.Forms;
using AGcountry_Beta.ViewModels;

namespace AGcountry_Beta.Views
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
