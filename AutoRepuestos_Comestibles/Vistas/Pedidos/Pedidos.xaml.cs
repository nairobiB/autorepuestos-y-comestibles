﻿using System;
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

namespace AutoRepuestos_Comestibles.Vistas.Pedidos
{
    /// <summary>
    /// Lógica de interacción para Pedidos.xaml
    /// </summary>
    public partial class Pedidos : UserControl
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void BtnAgregarPedido_Click(object sender, RoutedEventArgs e)
        {
            CrudPedidos ventana = new CrudPedidos();
            FramePedidos.Content = ventana;
        }
    }
}
