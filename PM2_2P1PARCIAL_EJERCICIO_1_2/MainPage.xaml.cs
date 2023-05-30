using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace PM2_2P1PARCIAL_EJERCICIO_1_2
{
    public partial class MainPage : ContentPage
    {
        public Persona Persona { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Persona = new Persona();
            BindingContext = Persona;
        }

        private async void Enviar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SegundaPagina(Persona));
        }
    }
}
