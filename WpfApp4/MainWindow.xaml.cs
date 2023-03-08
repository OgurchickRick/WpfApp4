using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            User.CreateAdmin();

        }



        private void Button_Log_Click(object sender, RoutedEventArgs e)
        {
            User user = User.LogIn(login_TextBox.Text, password_PasswordBox.Password);
            if (user == null)
                MessageBox.Show("Неверный логин или пароль");
            else
            {
                Hide();
                Log log = new Log();
                log.ShowDialog();
                Show();
            }
        }
    }
}
