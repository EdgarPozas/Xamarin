using Xamarin.Forms;

namespace CambiarPropiedadesCuadrado
{
	public partial class CambiarPropiedadesCuadradoPage : ContentPage
	{

		private Color colorCuadro = new Color();
		
		public CambiarPropiedadesCuadradoPage()
		{
			InitializeComponent();
		}

		void cambiar_valor_color(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			lbl_r.Text ="R "+ sl_r.Value.ToString("###");
			lbl_g.Text ="G " + sl_g.Value.ToString("###");
			lbl_b.Text ="B " + sl_b.Value.ToString("###");
			colorCuadro = new Color(sl_r.Value/255d,sl_g.Value/255d,sl_b.Value/255d);
			box.BackgroundColor = colorCuadro;
		}

		void cambiar_valor_tamaño(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			lbl_tam.Text = "Tamaño " + sl_tam.Value;
			box.Scale = sl_tam.Value;
		}

		void cambiar_valor_rotacion(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			lbl_rot_x.Text = "Rotar en X " + sl_rot_x.Value.ToString("###")+" grados";
			box.RotationX = (sl_rot_x.Value);
			lbl_rot_y.Text = "Rotar en Y " + sl_rot_y.Value.ToString("###")+" grados";
			box.RotationY = (sl_rot_y.Value);
		}
	}
}
