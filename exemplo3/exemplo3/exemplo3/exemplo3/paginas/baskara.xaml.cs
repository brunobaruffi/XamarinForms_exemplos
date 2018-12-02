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
	public partial class baskara : ContentPage
	{
		public baskara ()
		{
			InitializeComponent ();
            btn_calcular.Clicked += calcular;
        }

        private void calcular(object sender, EventArgs args)
        {
            double a, b, c, delta, x1, x2;
            a = Convert.ToDouble(txt_a.Text);
            b = Convert.ToDouble(txt_b.Text);
            c = Convert.ToDouble(txt_c.Text);

            delta = (b * b) - (4 * a * c);
            if(delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                DisplayAlert("Resposta", "x1=" + x1.ToString() + " x2=" + x2.ToString(), "OK");
            }
            else if(delta == 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                DisplayAlert("Resposta", "Apenas x1=" + x1.ToString(), "OK");
            }
            else
            {
                DisplayAlert("Resposta", "Não há reposta no conjunto dos numeros Reais", "OK");
            }
        }
	}
}