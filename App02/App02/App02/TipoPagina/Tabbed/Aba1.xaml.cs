using App02.TipoPagina.Carousel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02.TipoPagina.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aba1 : ContentPage
    {
        public Aba1()
        {
            InitializeComponent();
        }

        private void VoltarParaRoot(object sender, EventArgs args)
        {
            App.Current.MainPage = new Introducao();
        }
    }
}