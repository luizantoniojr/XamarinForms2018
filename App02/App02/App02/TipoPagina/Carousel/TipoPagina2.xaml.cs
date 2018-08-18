using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02.TipoPagina.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoPagina2 : ContentPage
    {
        public TipoPagina2()
        {
            InitializeComponent();
        }

        private void IrParaAbas(object sender, EventArgs eventArgs)
        {
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}