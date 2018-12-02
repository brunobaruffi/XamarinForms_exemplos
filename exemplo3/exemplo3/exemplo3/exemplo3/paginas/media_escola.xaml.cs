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
	public partial class media_escola : ContentPage
	{
		public media_escola ()
		{
			InitializeComponent ();
            btn_calcular.Clicked += calcular;

        }

        private void calcular(object sender, EventArgs args)
        {
            double trab, apos, tic, prova, media;
            trab = Convert.ToDouble(txt_trabalho.Text);
            apos = Convert.ToDouble(txt_apostila.Text);
            tic = Convert.ToDouble(txt_tic.Text);
            prova = Convert.ToDouble(txt_prova.Text);
            media = trab*0.16 + apos * 0.04 + tic * 0.2 + prova * 0.6;
            if (media >= 6)
            {
                DisplayAlert("NOTA", "Voce foi Aprovado. Sua media:" + media.ToString(), "OK");
            }
            else
            {
                DisplayAlert("NOTA", "Voce foi Reprovado. Sua media:" + media.ToString(), "OK");
            }
        }
	}
}