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

namespace RadioButtonYPasswordBox_3
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
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password.Length > 8)
            {
                MessageBox.Show("La contraseña no puede tener mas de 8 caracteres.");
                txtPassword.Password = txtPassword.Password.Substring(0, 8);
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuarioCorrecto = "angela";
            string passwordCorrecto = "1234";

            string usuario = txtUsuario.Text;
            string password = txtPassword.Password;

            if (usuario == usuarioCorrecto && password == passwordCorrecto)
            {
                MessageBox.Show("Login correcto");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
