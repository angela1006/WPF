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

namespace ComBox_Tooltip_4
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
        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbFrutas.SelectedItem;
            if (item == null) return;
            string fruta = item.Content.ToString();
            MessageBoxResult resultado = MessageBox.Show(
                $"¿Quieres confirmar tu selección de {fruta}?", 
                "Confirmación",                                
                MessageBoxButton.YesNoCancel,                  
                MessageBoxImage.Question);                      
            switch (resultado)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show($"Has confirmado {fruta}.",
                                    "Confirmado",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show($"Has rechazado {fruta}.",
                                    "Rechazado",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Warning);
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("No se realizó ninguna acción.",
                                    "Cancelado",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Stop);
                    break;
            }
        }
    }
}
