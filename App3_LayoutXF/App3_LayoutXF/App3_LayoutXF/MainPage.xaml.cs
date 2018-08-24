using App3_LayoutXF.Layouts.Absolute;
using App3_LayoutXF.Layouts.Grid;
using App3_LayoutXF.Layouts.Relative;
using App3_LayoutXF.Layouts.Scroll;
using App3_LayoutXF.Layouts.Stack;
using System;
using Xamarin.Forms;

namespace App3_LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AbrirAbsolute(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AbsolutePage());
        }

        private void AbrirGrid(object sender, EventArgs args)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void AbrirRelative(object sender, EventArgs args)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void AbrirScroll(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ScrollPage());
        }

        private void AbrirStack(object sender, EventArgs args)
        {
            Navigation.PushAsync(new StackPage());
        }
    }
}
