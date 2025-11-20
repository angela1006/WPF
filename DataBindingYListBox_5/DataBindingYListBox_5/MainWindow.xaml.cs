using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace DataBindingYListBox_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var lista = new List<Estudiante>
            {
                new Estudiante { Nombre = "Ana", Edad = 20, Nota = 9.0, Curso = "Matemáticas" },
                new Estudiante { Nombre = "Luis", Edad = 22, Nota = 7.5, Curso = "Matemáticas" },
                new Estudiante { Nombre = "María", Edad = 21, Nota = 8.5, Curso = "Física" },
                new Estudiante { Nombre = "Pedro", Edad = 23, Nota = 6.0, Curso = "Física" },
                new Estudiante { Nombre = "Sofía", Edad = 20, Nota = 9.5, Curso = "Química" },
                new Estudiante { Nombre = "Carlos", Edad = 22, Nota = 7.0, Curso = "Química" }
            };

            // Crear vista con agrupación
            var vista = new ListCollectionView(lista);
            vista.GroupDescriptions.Add(new PropertyGroupDescription("Curso"));

            // Enlazar al ListBox
            lbEstudiantes.ItemsSource = vista;
        }

        private void lbEstudiantes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbEstudiantes.SelectedItem is Estudiante est)
            {
                tbDetalles.Text =
                    $"Detalles del Estudiante:\n\n" +
                    $"Nombre: {est.Nombre}\n" +
                    $"Edad: {est.Edad}\n" +
                    $"Nota: {est.Nota}\n" +
                    $"Curso: {est.Curso}";
            }
        }
    }
}
