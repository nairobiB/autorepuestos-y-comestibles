using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AutoRepuestos_Comestibles.Vistas.Usuario;

namespace AutoRepuestos_Comestibles.Vistas.Usuario
{
    /// <summary>
    /// Interaction logic for CrudUsuarios.xaml
    /// </summary>
    public partial class CrudUsuarios : Page
    {
        public CrudUsuarios()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Content = new Usuarios();
        }
    }
}
