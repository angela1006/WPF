using System.Windows;

namespace TextBlockYLabel_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has pulsado el boton.");
        }

        private void StackPanel_ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evento Button.Click es bubbling");
        }
    }
}