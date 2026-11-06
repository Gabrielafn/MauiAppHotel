
namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_check_in.MinimumDate = DateTime.Now;
        dtpck_check_in.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_check_out.MinimumDate = dtpck_check_in.Date.Value.AddDays(1);
        dtpck_check_out.MaximumDate = dtpck_check_in.Date.Value.AddMonths(6);

    }

    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HospedagemContratada());
    }

    private async void Button_Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private void dtpck_check_in_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date.Value;
        dtpck_check_out.MinimumDate = dtpck_check_in.Date.Value.AddDays(1);
        dtpck_check_out.MaximumDate = dtpck_check_in.Date.Value.AddMonths(6);
    }
}
