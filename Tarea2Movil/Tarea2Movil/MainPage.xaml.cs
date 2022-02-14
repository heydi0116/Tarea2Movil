using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2Movil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.Datos
            {
                nombre = this.txtNombre.Text,
                apellido = this.txtApellido.Text,
                edad = Convert.ToInt32(this.txtEdad.Text),
                correo = this.txtCorreo.Text

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);

        }
    }
}
