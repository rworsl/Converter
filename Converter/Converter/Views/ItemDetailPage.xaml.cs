using Converter.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Converter.Views
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