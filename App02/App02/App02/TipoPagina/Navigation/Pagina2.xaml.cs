using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void ChamarMaster(object sender, EventArgs eventArgs)
        {
            App.Current.MainPage = new Master.Master();
        }
    }
}