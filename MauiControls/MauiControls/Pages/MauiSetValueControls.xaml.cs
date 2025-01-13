using System.Globalization;

namespace MauiControls.Pages;

public partial class MauiSetValueControls: ContentPage
{
    public MauiSetValueControls()
    {
        InitializeComponent();
    }

    private async void checkBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if(e.Value)
        {
            await DisplayAlert("CheckBox", "Marcado", "OK");
        } else
        {
            await DisplayAlert("CheckBox", "Desmarcado", "OK");
        }
    }

    private void checkBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void checkBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = Math.Round(slider1.Value, 2);
        lblSlider.Text = valor.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        lblStepper.Text = $"Valor do Stepper {value} ";
    }

    private async void switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if(e.Value)
        {
            await DisplayAlert("Switch", "Marcado", "OK");
        } else
        {
            await DisplayAlert("Switch", "Desmarcado", "OK");
        }
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        var data = ((DatePicker)sender).Date;
        var dataSelecionada = data.ToString("d", culture);
        await DisplayAlert("Data Slecionada", dataSelecionada, "OK");

    }

    private async void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if(time1 != null)
        {
            var horaSelecionada = time1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Hora Selecionada", horaSelecionada, "OK");
        }
    }
}