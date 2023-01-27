using DEINT_Ej7_Calculadora.MVVM.ViewModels;

namespace DEINT_Ej7_Calculadora.MVVM.Views;

public partial class CalculadoraView : ContentPage
{
	public CalculadoraView()
	{
		InitializeComponent();
		BindingContext = new CalculadoraViewModel();
	}
}