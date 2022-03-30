using FomeBateuApp.Dto;
using FomeBateuApp.Utiliarios.Entidades;
using FomeBateuWebService;
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FomeBateuApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageRestaurantes : ContentPage
	{
        public List<RestauranteDto> ListaRestaurantes; 
        public UsuarioDto _usuarioDto;
        public string BoasVindas;
        public string campoBusca { get; set; }
        public Command BuscaComando { get; }

        public PageRestaurantes(UsuarioDto usuarioDto)
        {
            InitializeComponent();
            _usuarioDto = usuarioDto;
            ListaRestaurantes = new List<RestauranteDto>();
            BoasVindas = $"Olá, {_usuarioDto.NomeCompleto}!";
            labelBoasVindas.Text = BoasVindas;
            btBusca.SearchButtonPressed += OnClickPesquisar;
            //MyListView.ItemsSource = ListaRestaurantes;
        }
        
		protected override async void OnAppearing()
        {
            base.OnAppearing();

            Api api = new Api("restaurantes/listar/");

            var resposta = api.Get();

            if (resposta.Codigo == Constantes.EnumWsCodigo.OK)
            {
                ListaRestaurantes = JsonUtils.Deserializar<List<RestauranteDto>>(resposta.Conteudo);

                MyListView.ItemsSource = ListaRestaurantes;
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

            List<ProdutoDto> produtoDtos = new List<ProdutoDto>();

            List<RestauranteDto> restauranteDtos = new List<RestauranteDto>();

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

            Api api2 = new Api("produtos/obterpordescricaobusca");
            var respostaProdutos = api2.Get(lista);

            if (respostaRestaurantes.Codigo == Constantes.EnumWsCodigo.OK || (respostaProdutos.Codigo == Constantes.EnumWsCodigo.OK))
            {
                produtoDtos = JsonUtils.Deserializar<List<ProdutoDto>>(respostaProdutos.Conteudo);

                restauranteDtos = JsonUtils.Deserializar<List<RestauranteDto>>(respostaRestaurantes.Conteudo);               

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