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
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopAsync();
            await Navigation.PushAsync(new Pagina3());
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pagina3());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private async void BtnAlerta_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Você foi alertado", "OK");
        }

        private async void DisplayAlerta_Clicked(object sender, EventArgs e)
        {
            Boolean resposta = await DisplayAlert("Iniciar", "Deseja iniciar o jogo", "Sim", "Não");

            if (resposta)
                lblmsg.Text = "Jogo iniciará";
            else
                lblmsg.Text = "Jogo não iniciará";
        }

        private async void BtnActionSheet_Clicked(object sender, EventArgs e)
        {
            var acao = await DisplayActionSheet("Enviar ?", "Cancela", null, "Email", "Twitter", "Facebook");
            lblmsg_2.Text = acao;
        }
    }
}

