using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02.TipoPagina.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        public void MudaConteudo3(object sender, EventArgs args)
        {
            Detail = new Conteudo3();
        }
        public void MudaConteudo2(object sender, EventArgs args)
        {
            Detail = new Conteudo2();
        }
        public void MudaConteudo(object sender, EventArgs args)
        {
            Detail = new Conteudo();
        }

    }
}