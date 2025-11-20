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

namespace RadioButtonYPasswordBox_5
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
        private void btnPagar_Click(object sender, RoutedEventArgs e)
        {
            string passwordCorrecta = "1234";
            string password = txtPassword.Password;

            if (password != passwordCorrecta)
            {
                MessageBox.Show("Contraseña incorrecta. Pago denegado.",
                                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string metodo = "";

            if (rbTarjeta.IsChecked == true)
                metodo = "Tarjeta de Crédito";
            else if (rbPayPal.IsChecked == true)
                metodo = "PayPal";
            else if (rbTransferencia.IsChecked == true)
                metodo = "Transferencia";
            else
            {
                MessageBox.Show("Debe seleccionar un método de pago.",
                                "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            MessageBox.Show($"Pago realizado con éxito mediante {metodo}.",
                            "Pago completado", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
