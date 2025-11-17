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

namespace CheckBoxYButton_6
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
        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            txtBloque.Inlines.Clear(); 

            if (chkAlternativo.IsChecked == true)
            {
                Run subrayado = new Run("Este texto está subrayado ")
                {
                    TextDecorations = TextDecorations.Underline
                };
                txtBloque.Inlines.Add(subrayado);
                Span negrita = new Span(new Run("y esta palabra está en NEGRITA"))
                {
                    FontWeight = FontWeights.Bold
                };
                txtBloque.Inlines.Add(negrita);
            }
            else
            {
                txtBloque.Inlines.Add(new Run("Este es un texto simple sin formato."));
            }
        }
    }
}
