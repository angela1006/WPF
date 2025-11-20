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

namespace RadioButtonYPasswordBox_4
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
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            string password = txtPassword.Password;

            if (password.Length <= 6)
            {
                MessageBox.Show("La contraseña debe tener más de 6 caracteres.",
                                "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            string nivel = "";

            if (rbBajo.IsChecked == true)
                nivel = "Bajo";
            else if (rbMedio.IsChecked == true)
                nivel = "Medio";
            else if (rbAlto.IsChecked == true)
                nivel = "Alto";
            else
            {
                MessageBox.Show("Debes seleccionar un nivel de seguridad.",
                                "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            MessageBox.Show($"Nivel seleccionado: {nivel}\nContraseña: {password}",
                            "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
