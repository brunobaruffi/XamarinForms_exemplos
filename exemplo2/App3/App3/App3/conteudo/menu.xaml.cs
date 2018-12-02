using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.conteudo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class menu : MasterDetailPage
	{
		public menu ()
		{
			InitializeComponent ();
            btn_inicio.Clicked += ir_inicio;
            btn_baskara.Clicked += ir_baskara;
            btn_ohm.Clicked += ir_ohm;
            btn_vcone.Clicked += ir_vcone;

        }
        public void ir_inicio(object sender, EventArgs args)
        {
            Detail = new conteudo.inicio();
            IsPresented = false;
        }
        public void ir_baskara(object sender, EventArgs args)
        {
            Detail = new conteudo.Baskara();
            IsPresented = false;
        }
        public void ir_ohm(object sender, EventArgs args)
        {
            Detail = new conteudo.ohm();
            IsPresented = false;
        }
        public void ir_vcone(object sender, EventArgs args)
        {
            Detail = new conteudo.vcone();
            IsPresented = false;
        }

    }
}