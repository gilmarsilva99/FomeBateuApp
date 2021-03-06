using FomeBateuWebService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FomeBateuWebService.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string ImageUrl = "undraw.jpg";
        public LoginPage()
        {
            InitializeComponent();
            imageLogin.Source = ImageUrl;
            this.BindingContext = new LoginViewModel();
        }
    }
}