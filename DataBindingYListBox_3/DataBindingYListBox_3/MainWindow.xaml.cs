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

namespace DataBindingYListBox_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty TextoUsuarioProperty =
        DependencyProperty.Register("TextoUsuario", typeof(string),
       typeof(MainWindow), new PropertyMetadata(string.Empty));
        public string TextoUsuario
        {
            get { return (string)GetValue(TextoUsuarioProperty); }
            set { SetValue(TextoUsuarioProperty, value); }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextoUsuario = textoUsuarioTextBox.Text;
        }
    }
}
