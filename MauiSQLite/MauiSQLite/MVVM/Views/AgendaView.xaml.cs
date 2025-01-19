using MauiSQLite.MVVM.ViewModels;
using MauiSQLite.Services;

namespace MauiSQLite.MVVM.Views;

public partial class AgendaView : ContentPage
{
	private readonly IAgendaService _agendaService;
    public AgendaView(IAgendaService agendaService)
    {
        _agendaService = agendaService;
        InitializeComponent();

        BindingContext = new AgendaViewModel(_agendaService);
    }
}