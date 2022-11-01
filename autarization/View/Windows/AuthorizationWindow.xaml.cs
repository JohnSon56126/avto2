using Autorization.Core;
using Autorization.Model;
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
using System.Windows.Shapes;

namespace autarization.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();

            

           // _user = UserParser.ParserFile("users2.txt").ToList();
        }
        private void btnSingin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbLogin.Text == string.Empty || tbPassword.Password == string.Empty)
                {
                    throw new Exception("Введите логин или пароль!");
                }

                if (UserLogic.Validate(tbLogin.Text, tbPassword.Password))
                {
                    new AdminWindow().Show();
                    Close();
                }
                else
                {
                    throw new Exception("Неверный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
