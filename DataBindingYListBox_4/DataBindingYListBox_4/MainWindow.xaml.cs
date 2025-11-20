using System.Windows;

namespace DataBindingYListBox_4
{
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty TextoUsuarioProperty =
            DependencyProperty.Register(
                "TextoUsuario",
                typeof(string),
                typeof(MainWindow),
                new PropertyMetadata(string.Empty));

        public string TextoUsuario
        {
            get => (string)GetValue(TextoUsuarioProperty);
            set => SetValue(TextoUsuarioProperty, value);
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; 
        }
    }
}
