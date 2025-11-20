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

namespace DataBindingYListBox_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty ColorDeFondoTextoProperty =
        DependencyProperty.Register(
        "ColorDeFondoTexto",
        typeof(Brush),
        typeof(MainWindow),
        new PropertyMetadata(Brushes.White));
        public Brush ColorDeFondoTexto
        {
            get { return (Brush)GetValue(ColorDeFondoTextoProperty); }
            set { SetValue(ColorDeFondoTextoProperty, value); }
        }
        public MainWindow()
        {
            InitializeComponent();
            MiTextBox.Background = ColorDeFondoTexto;
        }
        private void CambiarFondo_Click(object sender, RoutedEventArgs e)
        {
            ColorDeFondoTexto = ColorDeFondoTexto == Brushes.Yellow ? Brushes.White :
           Brushes.Yellow;
            MiTextBox.Background = ColorDeFondoTexto;
        }
    }
}
