using Xamarin.Forms;

namespace HolaMundo
{
	public partial class HolaMundoPage : ContentPage
	{
		public HolaMundoPage()
		{
			InitializeComponent();
		}

		void click_btn1(object sender, System.EventArgs e)
		{
			lbl1.Text = entry1.Text;	
		}

		async void click_btn2(object sender, System.EventArgs e)
		{
			await this.DisplayAlert("Titulo", "contenido", "aceptar", "cancelar");
		}
	}
}
