using FomeBateuWebService.Views;
using System.Collections.Generic;
using Xamarin.Forms;
using FomeBateuWebService.Dominio.Utilitarios.Entidades;
using FomeBateuApp.Utiliarios.Entidades;
using FomeBateuApp.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using FomeBateuApp.Dto;

namespace FomeBateuWebService.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public string Email { get; set; }
        public string Senha { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);           
        }

        private async void OnLoginClicked(object obj)
        {
            List<WsParametro> lista = new List<WsParametro>();

            if (!string.IsNullOrEmpty(Email.ToLower()) || !string.IsNullOrEmpty(Senha))
            {
                if (Email.ToLower().Contains("@") && Email.ToLower().Contains(".com"))
                {
                    lista = new List<WsParametro>() { new WsParametro() { Nome = "email", Valor = Email.ToLower() }, new WsParametro() { Nome = "senha", Valor = Senha } };
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("E-mail e/ou senha inválidos.", "", "OK");
                    return;
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Falha no login.", "Preencher campos.", "OK");
                return;
            }

            Api api = new Api("usuarios/autenticar");

            var resposta = api.Get(lista);

            if (resposta.Codigo == Constantes.EnumWsCodigo.OK)
            {
                UsuarioDto usuario = JsonUtils.Deserializar<UsuarioDto>(resposta.Conteudo);              

                await Application.Current.MainPage.Navigation.PushModalAsync(new PageRestaurantes(usuario), true);                
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Falha no login", resposta.MensagemErro, "OK");
                return;
            }

            
        }
    }
}
