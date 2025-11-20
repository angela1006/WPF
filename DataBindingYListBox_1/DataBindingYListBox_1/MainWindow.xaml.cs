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

namespace DataBindingYListBox_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty TamañoTextoProperty =
        DependencyProperty.Register(
        "TamañoTexto", 
        typeof(double), 
        typeof(MainWindow), 
        new PropertyMetadata(12.0)); 
        public double TamañoTexto
        {
            get { return (double)GetValue(TamañoTextoProperty); }
            set { SetValue(TamañoTextoProperty, value); }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TamañoTexto += 2.0; 
        }
    }
}
