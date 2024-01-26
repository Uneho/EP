using EducationPortal.controls;
using System;
using System.Windows;
using System.Windows.Input;


namespace EducationPortal
{
    public partial class MainWindow : Window
    {

        static public string loginActive;
        static public string whoIs;

        public MainWindow()
        {
            InitializeComponent();
        } 

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_To_Reg_Click(object sender, RoutedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Close();
        }

        //Input
        private void textLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtLogin.Focus();
        }

        private void txtLogin_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textLogin.Text) && textLogin.Text.Length > 0)
                textLogin.Visibility = Visibility.Collapsed;
            else
                textLogin.Visibility = Visibility.Visible;
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
                textPassword.Visibility = Visibility.Collapsed;
            else
                textPassword.Visibility = Visibility.Visible;
        }


        //showHidePass
        void ShowPassword()
        {

            txtBox.Visibility = Visibility.Visible;
            txtPassword.Visibility = Visibility.Hidden;
            txtBox.Text = txtPassword.Password;
        }
        void HidePassword()
        {
            txtBox.Visibility = Visibility.Hidden;
            txtPassword.Visibility = Visibility.Visible;
            txtPassword.Focus();
        }

        private void Button_Show_Pass_Click(object sender, RoutedEventArgs e)
        {
            ShowPassword();
            visiblePass.Visibility = Visibility.Hidden;
            hiddenPass.Visibility = Visibility.Visible;
        }

        private void Button_Hide_Pass_Click(object sender, RoutedEventArgs e)
        {
            HidePassword();
            hiddenPass.Visibility = Visibility.Hidden;
            visiblePass.Visibility = Visibility.Visible;
        }


        //backend
        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((txtLogin.Text != "") || (txtPassword.Password != ""))
                {
                    UserAuthorization.AuthorizationFunc(txtLogin.Text, txtPassword.Password);
                    switch (UserAuthorization.Role)
                    {
                        case null:
                            {
                                MessageBox.Show("Неверные данные", "Проверьте правильность ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                                txtLogin.ToolTip = "Некорректный ввод";
                                txtPassword.ToolTip = "Некорректный ввод";
                                break;
                            }
                        case "Преподаватель":
                            {
                                loginActive = textLogin.Text;
                                whoIs = "Преподаватель";
                                UserAuthorization.User = txtLogin.Text;

                                string firstName = UserAuthorization.AuthorizationName(txtLogin.Text);
                                UserAuthorization.firstName = firstName;
                                MessageBox.Show(firstName + ", Вы вошли в личный кабинет преподавателя", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                                this.Hide();
                                DBConnection.CloseDB();
                                AdminWindow adminWindow = new AdminWindow();
                                adminWindow.Show();
                                break;
                            }
                        case "Студент":
                            {
                                loginActive = textLogin.Text;
                                whoIs = "Студент";
                                UserAuthorization.User = txtLogin.Text;

                                string firstName = UserAuthorization.AuthorizationName(txtLogin.Text);
                                UserAuthorization.firstName = firstName;
                                MessageBox.Show(firstName + ", Вы вошли в личный кабинет студента", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                                this.Hide();
                                DBConnection.CloseDB();
                                AdminWindow adminWindow = new AdminWindow();
                                adminWindow.Show();
                                break;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Заполнение полей", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DBConnection.ConnectionDB();
        }
    }
}
