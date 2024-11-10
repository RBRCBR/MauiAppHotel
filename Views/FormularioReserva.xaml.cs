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
            // Verifica��o dos campos obrigat�rios
            if (string.IsNullOrWhiteSpace(entryNome.Text) ||
                string.IsNullOrWhiteSpace(CpfEntry.Text) ||
                string.IsNullOrWhiteSpace(entryEmail.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text) ||
                pckTipoQuarto.SelectedItem == null)
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos obrigat�rios.", "OK");
                return;
            }

            // Exemplo de exibi��o de confirma��o se todos os campos obrigat�rios forem preenchidos
            await DisplayAlert("Reserva Confirmada", "Sua reserva foi realizada com sucesso!", "OK");
            // Aqui, voc� pode implementar a l�gica para salvar os dados da reserva, se necess�rio
        }

        private void OnTelefoneTextChanged(object sender, TextChangedEventArgs e)
        {
            // Remover qualquer caractere que n�o seja n�mero
            var newText = new string(e.NewTextValue.Where(char.IsDigit).ToArray());

            // Limitar a quantidade de caracteres a 11 (por exemplo, para DDD + n�mero)
            if (newText.Length > 11)
            {
                newText = newText.Substring(0, 11);
            }

            // Atualizar o texto exibido sem caracteres inv�lidos
            if (TelefoneEntry.Text != newText)
            {
                TelefoneEntry.Text = newText;
            }
        }

        private void OnCpfTextChanged(object sender, TextChangedEventArgs e)
        {
            // Remover qualquer caractere que n�o seja n�mero
            var newText = new string(e.NewTextValue.Where(char.IsDigit).ToArray());

            // Limitar o n�mero de caracteres a 11 (formato padr�o para CPF)
            if (newText.Length > 11)
            {
                newText = newText.Substring(0, 11);
            }

            // Atualizar o texto do Entry sem caracteres inv�lidos
            if (CpfEntry.Text != newText)
            {
                CpfEntry.Text = newText;
            }
        }

        // Adicionando o m�todo para o evento 'OnSobreClicked'
        private async void OnSobreClicked(object sender, EventArgs e)
        {
            // Aqui voc� pode implementar a l�gica para mostrar mais informa��es sobre a reserva
            await DisplayAlert("Sobre", "Informa��es sobre o servi�o de reserva.", "OK");
        }
    }
}
