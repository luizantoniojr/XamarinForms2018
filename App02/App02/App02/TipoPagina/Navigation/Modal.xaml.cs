using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal : ContentPage
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void FecharModal(object sender, EventArgs eventArgs)
        {
            Navigation.PopModalAsync();
        }
    }
}