namespace MauiControls.Pages;

public partial class MauiEditorControls : ContentPage
{
	public MauiEditorControls()
	{
		InitializeComponent();
		this.BindingContext = this;
		this.IsBusy = false;
        btnLogin.Clicked += BtnLogin_Clicked;
	}

    private async void BtnLogin_Clicked(object? sender, EventArgs e)
    {
		//ativa o AcivityIndicator
		this.IsBusy = true;

		await Task.Delay(8000);
        this.IsBusy = false;
    }
}