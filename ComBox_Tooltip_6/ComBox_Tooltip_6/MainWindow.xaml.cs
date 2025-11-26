using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ComBox_Tooltip_6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Tema
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent(); 

            List<Tema> temas = new List<Tema>
            {
                new Tema { Nombre = "Claro",  Descripcion = "Tema claro con fondo blanco" },
                new Tema { Nombre = "Oscuro", Descripcion = "Tema oscuro con fondo negro" },
                new Tema { Nombre = "Azul",   Descripcion = "Tema azul con fondo azul" }
            };
            comboTemas.ItemsSource = temas;
            comboTemas.SelectedIndex = 0;
        }
        private void comboTemas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboTemas.SelectedItem is Tema tema)
            {
                switch (tema.Nombre)
                {
                    case "Claro":
                        this.Background = Brushes.White;
                        if (txtEjemplo != null)
                        {
                            txtEjemplo.Foreground = Brushes.Black;
                            txtEjemplo.FontSize = 16;
                        }
                        break;
                    case "Oscuro":
                        this.Background = Brushes.Black;
                        if (txtEjemplo != null)
                        {
                            txtEjemplo.Foreground = Brushes.White;
                            txtEjemplo.FontSize = 24;
                        }
                        break;
                    case "Azul":
                        this.Background = Brushes.Blue;
                        if (txtEjemplo != null)
                        {
                            txtEjemplo.Foreground = Brushes.White;
                            txtEjemplo.FontSize = 20;
                        }
                        break;
                }
            }
        }
    }
}