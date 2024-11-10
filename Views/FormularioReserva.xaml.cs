using MauiAppHotel.Views;

namespace MauiAppHotel.Views
{
    public partial class FormularioReserva : ContentPage
    {
        public FormularioReserva()
        {
            InitializeComponent();
        }

        private async void OnConfirmarReservaClicked(object sender, EventArgs e)
        {
            // Verificação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(entryNome.Text) ||
                string.IsNullOrWhiteSpace(CpfEntry.Text) ||
                string.IsNullOrWhiteSpace(entryEmail.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text) ||
                pckTipoQuarto.SelectedItem == null)
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos obrigatórios.", "OK");
                return;
            }

            // Exemplo de exibição de confirmação se todos os campos obrigatórios forem preenchidos
            await DisplayAlert("Reserva Confirmada", "Sua reserva foi realizada com sucesso!", "OK");
            // Aqui, você pode implementar a lógica para salvar os dados da reserva, se necessário
        }

        private void OnTelefoneTextChanged(object sender, TextChangedEventArgs e)
        {
            // Remover qualquer caractere que não seja número
            var newText = new string(e.NewTextValue.Where(char.IsDigit).ToArray());

            // Limitar a quantidade de caracteres a 11 (por exemplo, para DDD + número)
            if (newText.Length > 11)
            {
                newText = newText.Substring(0, 11);
            }

            // Atualizar o texto exibido sem caracteres inválidos
            if (TelefoneEntry.Text != newText)
            {
                TelefoneEntry.Text = newText;
            }
        }

        private void OnCpfTextChanged(object sender, TextChangedEventArgs e)
        {
            // Remover qualquer caractere que não seja número
            var newText = new string(e.NewTextValue.Where(char.IsDigit).ToArray());

            // Limitar o número de caracteres a 11 (formato padrão para CPF)
            if (newText.Length > 11)
            {
                newText = newText.Substring(0, 11);
            }

            // Atualizar o texto do Entry sem caracteres inválidos
            if (CpfEntry.Text != newText)
            {
                CpfEntry.Text = newText;
            }
        }

        // Adicionando o método para o evento 'OnSobreClicked'
        private async void OnSobreClicked(object sender, EventArgs e)
        {
            // Aqui você pode implementar a lógica para mostrar mais informações sobre a reserva
            await DisplayAlert("Sobre", "Informações sobre o serviço de reserva.", "OK");
        }
    }
}
