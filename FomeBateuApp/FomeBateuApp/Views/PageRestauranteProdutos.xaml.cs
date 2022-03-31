using FomeBateuApp.Dto;
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
	public partial class PageRestauranteProdutos : ContentPage
	{
		public RestauranteDto _Restaurante;
		

        public PageRestauranteProdutos (RestauranteDto restauranteDto)
		{
			InitializeComponent ();
			_Restaurante = restauranteDto;
			labelRestauranteNome.Text = _Restaurante.NomeFantasia;
			//labelEnderecoRestaurante.Text = _Restaurante.Enderecos.FirstOrDefault().Endereco;
			labelRestauranteFone.Text = $"Tel: {_Restaurante.Fone1}";
			labelRestauranteFrete.Text = _Restaurante.TempoFrete;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();            
            
            MyListView.ItemsSource = _Restaurante.Produtos;           
                
        }

    }
}