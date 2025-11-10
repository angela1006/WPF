using System.Windows;

namespace TextBlockYLabel_3
{
    public partial class MainWindow : Window
    {
        // error de compilacioooon -> arreglar
        public MainWindow()
        {

            InitializeComponent();
        }

        private void MyButton_Click_Handler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1. ¡Haz click!\n";

        }

        private void StackPanel_Button_Click_Handler(object sender, RoutedEventArgs e)
        {
            string evento = "Button.Click ";
            string comportamiento = "Este es un evento de tipo 'Bubbling' (burbujeo). " +
                                    "Se originó en un boton hasta subir " +
                                    "por el árbol hasta llegar a el StackPanel.";

            MessageBox.Show($"capturado por el stackpanel!\n" +
                            $"Evento manejado: {evento}\n" +
                            $"Comportamiento: {comportamiento}\n" +
                            $"Elemento que originó el evento: {e.OriginalSource}");
        }
    }
}