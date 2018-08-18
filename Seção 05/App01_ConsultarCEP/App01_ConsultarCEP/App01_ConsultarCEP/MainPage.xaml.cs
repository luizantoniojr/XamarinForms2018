using App01_ConsultarCEP.Interface;
using System;
using System.Net;
using Xamarin.Forms;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        private readonly IViaCepService viaCepService;

        public MainPage(IViaCepService viaCepService)
        {
            this.viaCepService = viaCepService;
            InitializeComponent();
            BOTAO.Clicked += BuscarEndereco;
        }

        private void BuscarEndereco(object sender, EventArgs args)
        {
            try
            {
                var resultado = viaCepService.BuscarEnderecoViaCep(CEP.Text);
                if (resultado.EhValido)
                {
                    LOGRADOURO.Text = $"Logradouro: {resultado.Endereco.Logradouro}";
                    BAIRRO.Text = $"Bairro: {resultado.Endereco.Bairro}";
                    LOCALIDADE.Text = $"Localidade: {resultado.Endereco.Localidade}";
                    UF.Text = $"UF: {resultado.Endereco.UF}";
                }
                else
                    DisplayAlert("Atenção", resultado.MensagemErro, "Entendi");
            }
            catch (Exception)
            {
                DisplayAlert("Atenção", "Ocorreu um erro inesperado, por favor, tente novamente mais tarde", "Entendi");
            }
        }
    }
}
