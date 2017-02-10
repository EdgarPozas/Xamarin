using Xamarin.Forms;

namespace CambiarColores
{
	public partial class CambiarColoresPage : ContentPage
	{
		public CambiarColoresPage()
		{
			InitializeComponent();
		}

		void cambiar_color(object sender, System.EventArgs e)
		{
			Color color = new Color();
			switch (picker.SelectedIndex)
			{
				case 0:
					color = Color.Red;
					break;
				case 1:
					color = Color.Green;
					break;
				case 2:
					color = Color.Blue;
					break;	
				default:
					color = Color.Black;
					break;
			}
			box.BackgroundColor=color;
		}
	}
}
