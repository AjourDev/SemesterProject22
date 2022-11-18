using System.ComponentModel;
using Xamarin.Forms;
using BotNotifier.ViewModels;

namespace BotNotifier.Views
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
