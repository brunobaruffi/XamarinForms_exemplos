using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exemplo4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btn_ir_absolute.Clicked += ir_abs;
            btn_ir_grade.Clicked += ir_grid;
            btn_ir_stack.Clicked += ir_stack;
        }

        private void ir_grid(object sender, EventArgs args)
        {
            App.Current.MainPage = new Grid.grade();
        }
        private void ir_abs(object sender, EventArgs args)
        {
            App.Current.MainPage = new Absolute.absolute();
        }
        private void ir_stack(object sender, EventArgs args)
        {
            App.Current.MainPage = new Stack.stack();
        }
    }
}
