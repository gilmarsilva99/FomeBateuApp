using FomeBateuApp.Dto;
using FomeBateuApp.Utiliarios.Entidades;
using FomeBateuWebService;
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FomeBateuApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageRestaurantes : ContentPage
	{
        //public List<RestauranteDto> ListaRestaurantes;
        public ObservableCollection<RestauranteDto> ListaRestaurantes { get; set; }
        public List<RestauranteDto> ListaRestaurantesOriginal;
        public UsuarioDto _usuarioDto;
        public string BoasVindas;
        public string campoBusca { get; set; }
        public Command BuscaComando { get; }

        public RestauranteDto SelectedItem { get; set; }

        public PageRestaurantes(UsuarioDto usuarioDto)
        {
            InitializeComponent();
            BindingContext = this;
            _usuarioDto = usuarioDto;
            ListaRestaurantes = new ObservableCollection<RestauranteDto>();
            ListaRestaurantesOriginal = new List<RestauranteDto>();
            BoasVindas = $"Olá, {_usuarioDto.NomeCompleto}!";
            labelEnderecoUsuario.Text = _usuarioDto.Endereco.FirstOrDefault().Endereco;
            labelBoasVindas.Text = BoasVindas;
            btBusca.SearchButtonPressed += OnClickPesquisar;
            btBusca.TextChanged += OnTextChangedPesquisar;
            //MyListView.ItemsSource = ListaRestaurantes;
        }

        private void OnTextChangedPesquisar(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                ListaRestaurantes.Clear();
                ListaRestaurantesOriginal.ForEach(ListaRestaurantes.Add);
                //MyListView.ItemsSource = ListaRestaurantes;
            }
        }

        public Command ItemSelectedCommand
        {
            get
            {
                return new Command (async _ =>
                {
                    if (SelectedItem == null)
                        return;

                    await Application.Current.MainPage.Navigation.PushModalAsync(new PageRestauranteProdutos(SelectedItem), true);

                    SelectedItem = null;
                });
            }
        }

             
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            Api api = new Api("restaurantes/listar/");

            var resposta = api.Get();
           

            if (resposta.Codigo == Constantes.EnumWsCodigo.OK)
            {
                ListaRestaurantes = JsonUtils.Deserializar<ObservableCollection<RestauranteDto>>(resposta.Conteudo);

                MyListView.ItemsSource = ListaRestaurantes;
                ListaRestaurantesOriginal.Clear();
                ListaRestaurantesOriginal.AddRange(ListaRestaurantes);
                //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");

                //await Navigation.PushModalAsync(new Page);
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Falha ao listar Restaurantes.", resposta.MensagemErro, "OK");
                return;
            }
        }

        private async void OnClickPesquisar(object sender, EventArgs e)
        {
            List<WsParametro> lista = new List<WsParametro>();         

            campoBusca = ((SearchBar)sender).Text.Trim();

            if (!string.IsNullOrEmpty(campoBusca))
            {

                lista = new List<WsParametro>() { new WsParametro() { Nome = "descricao", Valor = campoBusca.ToLower() }};               

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Digite algo.", "", "OK");
                return;
            }

            Api api = new Api("restaurantes/obterpordescricaobusca");
            var respostaRestaurantes = api.Get(lista);

            

            if (respostaRestaurantes.Codigo == Constantes.EnumWsCodigo.OK )
            {
                ListaRestaurantes.Clear();

                ListaRestaurantes = JsonUtils.Deserializar<ObservableCollection<RestauranteDto>>(respostaRestaurantes.Conteudo);
                                
                MyListView.ItemsSource = ListaRestaurantes;

                //Carregar um listview p/ restaurante e um para produtos.
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Sem resultados", "", "OK");
                return;
            }


        }

        private void MyListView_MeasureInvalidated(object sender, EventArgs e)
        {

        }
    }
}