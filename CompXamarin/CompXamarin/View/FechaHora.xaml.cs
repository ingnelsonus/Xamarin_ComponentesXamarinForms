using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FechaHora : ContentPage
    {
        public FechaHora()
        {
            InitializeComponent();
        }

        private void dtFecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblResultadp.Text = dtFecha.Date.ToString("MM/dd/yyyy");
        }

        private void tpHora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lblHora.Text = tpHora.Time.ToString();
        }
    }
}