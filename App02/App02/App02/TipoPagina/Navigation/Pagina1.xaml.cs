using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void MudarParaPagina2(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new Pagina2());
        }

        private void ChamarModal(object sender, EventArgs eventArgs)
        {
            Navigation.PushModalAsync(new Modal());
        }
    }
}