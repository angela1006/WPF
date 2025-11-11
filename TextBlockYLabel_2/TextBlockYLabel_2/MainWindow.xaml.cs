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

namespace TextBlockYLabel_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Content = null;

            Grid grid = new Grid();

            Button boton = new Button();
            boton.FontWeight = FontWeights.Bold;
            boton.HorizontalAlignment = HorizontalAlignment.Center;
            boton.VerticalAlignment = VerticalAlignment.Center;

            WrapPanel panel = new WrapPanel();

            TextBlock verde = new TextBlock();
            verde.Text = "verde";
            verde.Foreground = new SolidColorBrush(Colors.Green);
            verde.Margin = new Thickness(2);

            TextBlock azul = new TextBlock();
            azul.Text = "azul";
            azul.Foreground = new SolidColorBrush(Colors.Blue);
            azul.Margin = new Thickness(2);

            TextBlock sinFormato = new TextBlock();
            sinFormato.Text = "Sin formato";
            sinFormato.Margin = new Thickness(2);

            panel.Children.Add(verde);
            panel.Children.Add(azul);
            panel.Children.Add(sinFormato);

            boton.Content = panel;

            grid.Children.Add(boton);

            this.Content = grid;
        }
    }
}
