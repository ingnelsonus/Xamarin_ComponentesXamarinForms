using CompXamarin.Model;
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
    public partial class MenuPrincipal : ContentPage
    {
        public IList<MComidas> Comidas { get; private set; }

        public MenuPrincipal()
        {
            InitializeComponent();
            Comidas = new List<MComidas>();
            Comidas.Add(new MComidas { Nombre = "Imagen Circular",Imagen="Angulo.png" });
            Comidas.Add(new MComidas { Nombre = "Alertas", Imagen = "Alertas.png" });
            Comidas.Add(new MComidas { Nombre = "Tarjetas", Imagen = "Tarjeta.png" });
            Comidas.Add(new MComidas { Nombre = "Fechas", Imagen = "calendario.png" });

            BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MComidas seleccion = e.Item as MComidas;
            if(seleccion.Nombre=="Tarjetas")
            {
                Navigation.PushAsync(new Tarjetas());
            }
            if(seleccion.Nombre=="Alertas")
            {
                Navigation.PushAsync(new Alertas());
            }
            if (seleccion.Nombre == "Fechas")
            {
                Navigation.PushAsync(new FechaHora());
            }
        }

       
    }
}