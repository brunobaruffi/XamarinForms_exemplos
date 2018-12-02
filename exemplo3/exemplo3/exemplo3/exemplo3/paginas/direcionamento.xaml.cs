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
	public partial class direcionamento : ContentPage
	{
		public direcionamento ()
		{
			InitializeComponent ();
            btn_media_escola.Clicked += ir_media_escola;
            btn_baskara.Clicked += ir_baskara;
            btn_ohm.Clicked += ir_ohm;

        }

        private void ir_media_escola(object sender, EventArgs args)
        {
            Navigation.PushAsync(new paginas.media_escola());
        }

        private void ir_baskara(object sender, EventArgs args)
        {
            Navigation.PushAsync(new paginas.baskara());
        }

        private void ir_ohm(object sender, EventArgs args)
        {
            Navigation.PushAsync(new paginas.ohm());
        }
	}
}