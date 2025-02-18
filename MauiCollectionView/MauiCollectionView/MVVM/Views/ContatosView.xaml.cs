using MauiCollectionView.MVVM.ViewModels;
using System.Diagnostics;

namespace MauiCollectionView.MVVM.Views;

public partial class ContatosView : ContentPage
{
	public ContatosView()
	{
		InitializeComponent();
		BindingContext = new ContatoViewModel();
	}

    private void cv1_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        Debug.Write("----------------------------------------");
        Debug.WriteLine("HorizontalDelta: " + e.HorizontalDelta);
        Debug.WriteLine("VerticalDelta: " + e.VerticalDelta);
        Debug.WriteLine("HorizontalOffset: " + e.HorizontalOffset);
        Debug.WriteLine("VerticalOffset: " + e.VerticalOffset);
        Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
        Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
        Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
        Debug.Write("----------------------------------------");
    }
}