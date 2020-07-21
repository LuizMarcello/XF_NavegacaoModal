using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavegacaoModal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopToRootAsync();
            await Navigation.PopAsync();
           
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}