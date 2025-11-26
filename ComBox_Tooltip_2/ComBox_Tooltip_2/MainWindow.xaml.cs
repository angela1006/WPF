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

namespace ComBox_Tooltip_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem itemSeleccionado = (ComboBoxItem)cbCategorias.SelectedItem;
            if (itemSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona una categoría primero.");
                return;
            }
            string categoria = itemSeleccionado.Content.ToString();
            Button botonPulsado = (Button)sender;
            string accion = botonPulsado.Content.ToString();
            string mensaje = $"Has realizado {accion} en la {categoria}.";
            MessageBox.Show(mensaje,
                            "Información",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }
    }
}
