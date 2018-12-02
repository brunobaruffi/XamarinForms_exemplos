using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.paginas_carrossel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina3 : ContentPage
	{
		public Pagina3 ()
		{
			InitializeComponent ();
            btn_continuar.Clicked += continuar_programa;
		}

        public void continuar_programa(object sender, EventArgs args)
        {   
            App.Current.MainPage = new conteudo.menu();
        }
	}
}