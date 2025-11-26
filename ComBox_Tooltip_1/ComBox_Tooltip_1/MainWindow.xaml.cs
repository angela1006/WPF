using System;
using System.Collections.Generic; 
using System.Windows;
using System.Windows.Controls;     

namespace ComBox_Tooltip_1
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string ImagenRuta { get; set; }
    }

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CargarAnimales();
        }

        private void CargarAnimales()
        {
            List<Animal> lista = new List<Animal>
            {
                new Animal { Nombre = "Perro",  ImagenRuta = "pack://application:,,,/dog.jpg" },
                new Animal { Nombre = "Gato",   ImagenRuta = "pack://application:,,,/cat.jpg" },
                new Animal { Nombre = "Pajaro", ImagenRuta = "pack://application:,,,/bird.jpg" }
            };
            cbAnimales.ItemsSource = lista;
        }
        private void cbAnimales_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbAnimales.SelectedItem != null)
            {
                Animal animalElegido = (Animal)cbAnimales.SelectedItem;
                MessageBox.Show($"Has seleccionado: {animalElegido.Nombre}");
            }
        }
    }
}