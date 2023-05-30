using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2_2P1PARCIAL_EJERCICIO_1_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaPagina : ContentPage
    {
        public SegundaPagina(Persona persona)
        {
            InitializeComponent();
            BindingContext = persona;
        }
    }
}