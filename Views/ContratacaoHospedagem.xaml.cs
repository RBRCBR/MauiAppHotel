using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormularioReserva());
        }

        // M�todo para navegar at� a p�gina "Sobre"
        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Sobre());
        }
    }
}
