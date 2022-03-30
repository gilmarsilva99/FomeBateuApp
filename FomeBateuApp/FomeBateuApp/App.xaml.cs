using FomeBateuWebService.Views;
using Xamarin.Forms;

namespace FomeBateuWebService
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //var imagem1 = new Image
            //{
            //    Aspect = Aspect.AspectFit,
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Start,
            //    //Margin = Size.Zero
            //};

            //imagem1.Source = ImageSource.FromFile("comida.jpg");

            //DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
            //{
            //    BackgroundColor = Color.Silver,
            //    Content = new StackLayout
            //    {
            //        Spacing = 0,
            //        VerticalOptions = LayoutOptions.Start,
            //        Orientation = StackOrientation.Vertical,
            //        Children = { imagem1}
            //    }
            //};
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
