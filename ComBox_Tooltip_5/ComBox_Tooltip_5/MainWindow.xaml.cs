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

namespace ComBox_Tooltip_5
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
        private void txtEdad_LostFocus(object sender, RoutedEventArgs e)
        {
            string textoIntroducido = txtEdad.Text;
            if (string.IsNullOrWhiteSpace(textoIntroducido)) return;
            bool esNumero = int.TryParse(textoIntroducido, out int edad);

            if (esNumero)
            {
                MessageBox.Show("Edad válida",
                                "Éxito",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                txtEdad.BorderBrush = Brushes.Green;
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.",
                                "Error de formato",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                txtEdad.Clear();
            }
        }
    }
}
