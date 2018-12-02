using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exemplo3.carrossel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pagina2 : ContentPage
	{
		public pagina2 ()
		{
			InitializeComponent ();
            btn_comecar.Clicked += direcionar;
            
		}

        private void direcionar(object sender, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new paginas.direcionamento())
            {
                BarBackgroundColor = Color.DeepSkyBlue
            };
        }
	}
}