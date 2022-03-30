using FomeBateuWebService.ViewModels;
using Xamarin.Forms;

namespace FomeBateuWebService.Views
{
    public partial class NewItemPage : ContentPage
    {
        //public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}