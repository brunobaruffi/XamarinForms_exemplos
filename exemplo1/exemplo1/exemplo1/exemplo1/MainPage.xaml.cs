using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exemplo1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btn_calcular.Clicked += calcular;
        }

        private void calcular(object sender, EventArgs args)
        {
            double nota1, nota2, nota3, media;
            nota1 = Convert.ToDouble(txt_nota1.Text);
            nota2 = Convert.ToDouble(txt_nota2.Text);
            nota3 = Convert.ToDouble(txt_nota3.Text);
            media = (nota1 + nota2 + nota3) / 3;
            lbl_media.Text = "Sua media é:" + media.ToString();
            DisplayAlert("Mensagem", "Sua nota é:" + media.ToString(), "OK");
        }
    }
}
