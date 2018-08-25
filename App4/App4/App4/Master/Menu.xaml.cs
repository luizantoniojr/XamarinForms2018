using App4.Pages;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void IrParaPerfil(object sender, EventArgs arags)
        {
            Detail = new Profile();
            IsPresented = false;
        }
            
        public void IrParaSobre(object sender, EventArgs arags)
        {
            Detail = new About();
            IsPresented = false;
        }
    }
}