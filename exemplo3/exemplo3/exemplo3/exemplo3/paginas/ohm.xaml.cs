using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exemplo3.paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ohm : ContentPage
	{
		public ohm ()
		{
			InitializeComponent ();
            btn_calcular.Clicked += calcular;
        }

        private void calcular(object sender, EventArgs args)
        {
            double tensao, resistencia, corrente;
            tensao = Convert.ToDouble(txt_tensao.Text);
            resistencia = Convert.ToDouble(txt_resistencia.Text);
            corrente = tensao / resistencia;
            DisplayAlert("Corrente", "Sua corrente é:" + corrente + " A", "OK");
        }
	}
}