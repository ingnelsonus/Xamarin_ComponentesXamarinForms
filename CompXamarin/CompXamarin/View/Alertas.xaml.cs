using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace CompXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alertas : ContentPage
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void btnAlertas_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Titulo", "Mensaje", "OK");
            PopupNavigation.Instance.PushAsync(new AlertaN1());
        }
    }
}