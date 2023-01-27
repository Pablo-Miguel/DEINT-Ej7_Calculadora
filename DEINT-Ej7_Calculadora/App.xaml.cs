using DEINT_Ej7_Calculadora.MVVM.Views;

namespace DEINT_Ej7_Calculadora;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculadoraView();
	}
}
