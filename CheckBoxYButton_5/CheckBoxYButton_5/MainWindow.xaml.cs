using System.Windows;

namespace CheckBoxYButton_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void todoChanged(object sender, RoutedEventArgs e)
        {
            bool? check = cbTodos.IsChecked;
            cbM1.IsChecked = check;
            cbM2.IsChecked = check;
            cbM3.IsChecked = check;
        }
        private void indivChanged(object sender, RoutedEventArgs e)
        {
            int marcados = 0;

            if (cbM1.IsChecked == true) marcados++;
            if (cbM2.IsChecked == true) marcados++;
            if (cbM3.IsChecked == true) marcados++;

            if (marcados == 3)
                cbTodos.IsChecked = true;
            else if (marcados == 0)
                cbTodos.IsChecked = false;
            else
                cbTodos.IsChecked = null; 
        }
    }
}
