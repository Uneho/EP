using EducationPortal.controls;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EducationPortal
{
    public partial class RegisterPage : Window
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DBConnection.ConnectionDB();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_To_Login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        //input
        private void textLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtLogin.Focus();
        }

        private void txtLogin_TextChanged(object sender, TextChangedEventArgs e)
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

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textPhone.Text) && textPhone.Text.Length > 0)
                textPhone.Visibility = Visibility.Collapsed;
            else
                textPhone.Visibility = Visibility.Visible;
        }

        private void textPhone_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPhone.Focus();
        }

        private void txtBirth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBirth.Text) && textBirth.Text.Length > 0)
                textBirth.Visibility = Visibility.Collapsed;
            else
                textBirth.Visibility = Visibility.Visible;
        }

        private void textBirth_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBirth.Focus();
        }

        private void txtAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textAge.Text) && textAge.Text.Length > 0)
                textAge.Visibility = Visibility.Collapsed;
            else
                textAge.Visibility = Visibility.Visible;
        }

        private void textAge_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtAge.Focus();
        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textLastName.Text) && textLastName.Text.Length > 0)
                textLastName.Visibility = Visibility.Collapsed;
            else
                textLastName.Visibility = Visibility.Visible;
        }

        private void textLastName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtLastName.Focus();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textName.Text) && textName.Text.Length > 0)
                textName.Visibility = Visibility.Collapsed;
            else
                textName.Visibility = Visibility.Visible;
        }

        private void textName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtName.Focus();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textEmail.Text) && textEmail.Text.Length > 0)
                textEmail.Visibility = Visibility.Collapsed;
            else
                textEmail.Visibility = Visibility.Visible;
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

        void ShowRepeatPassword()
        {

            txtRepeatBox.Visibility = Visibility.Visible;
            txtRepeatPassword.Visibility = Visibility.Hidden;
            txtRepeatBox.Text = txtPassword.Password;
        }
        void HideRepeatPassword()
        {
            txtRepeatBox.Visibility = Visibility.Hidden;
            txtRepeatPassword.Visibility = Visibility.Visible;
            txtRepeatPassword.Focus();
        }
        private void Button_Reg_Show_Pass_Click(object sender, RoutedEventArgs e)
        {
            ShowPassword();
            visiblePass.Visibility = Visibility.Hidden;
            hiddenPass.Visibility = Visibility.Visible;
        }

        private void Button_Reg_Hide_Pass_Click(object sender, RoutedEventArgs e)
        {
            HidePassword();
            hiddenPass.Visibility = Visibility.Hidden;
            visiblePass.Visibility = Visibility.Visible;
        }

        private void textRepeatPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtRepeatPassword.Focus();
        }

        private void txtRepeatPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepeatPassword.Password) && txtRepeatPassword.Password.Length > 0)
                textRepeatPassword.Visibility = Visibility.Collapsed;
            else
                textRepeatPassword.Visibility = Visibility.Visible;
        }

        private void visibleRepeatPass_Click(object sender, RoutedEventArgs e)
        {
            ShowRepeatPassword();
            visibleRepeatPass.Visibility = Visibility.Hidden;
            hiddenRepeatPass.Visibility = Visibility.Visible;
        }

        private void hiddenRepeatPass_Click(object sender, RoutedEventArgs e)
        {
            HideRepeatPassword();
            hiddenRepeatPass.Visibility = Visibility.Hidden;
            visibleRepeatPass.Visibility = Visibility.Visible;
        }


        private void textGroup_MouseDown(object sender, MouseButtonEventArgs e)
        {         
            txtGroup.Focus();
        }
        private void txtGroup_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGroup.Text) && txtGroup.Text.Length > 0)
                textGroup.Visibility = Visibility.Collapsed;
            else
                textGroup.Visibility = Visibility.Visible;
        }

        private void textSurname_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtSurname.Focus();
        }

        private void txtSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSurname.Text) && txtSurname.Text.Length > 0)
                textSurname.Visibility = Visibility.Collapsed;
            else
                textSurname.Visibility = Visibility.Visible;
        }

        // catch (Exception ex) { MessageBox.Show(ex.Message); }

        private void Button_Register_User_Click(object sender, RoutedEventArgs e)
        {
            ClearValidationEmptyErrors();

            // Проверка на пустоту полей
            FieldValidator.ShowEmptyFieldError(txtPassword, "Пароль");
            FieldValidator.ShowEmptyFieldError(txtRepeatPassword, "Повторите пароль");
            FieldValidator.ShowEmptyFieldError(txtLogin, "Логин");
            FieldValidator.ShowEmptyFieldError(txtPassword, "Пароль");
            FieldValidator.ShowEmptyFieldError(txtRepeatPassword, "Повторите пароль");
            FieldValidator.ShowEmptyFieldError(txtEmail, "Email");
            FieldValidator.ShowEmptyFieldError(txtGroup, "Группа");
            FieldValidator.ShowEmptyFieldError(txtName, "Имя");
            FieldValidator.ShowEmptyFieldError(txtLastName, "Фамилия");
            FieldValidator.ShowEmptyFieldError(txtSurname, "Отчество");
            FieldValidator.ShowEmptyFieldError(txtAge, "Возраст");
            FieldValidator.ShowEmptyFieldError(txtPhone, "Номер телефона");
            FieldValidator.ShowEmptyFieldError(txtBirth, "Дата рождения");

            // Проверка наличия ошибок
            if (HasValidationErrors())
            {
                MessageBox.Show("Заполните все обязательные поля.", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Все поля заполнены продолжаем с регистрацией

            ClearValidationErrors();

            UserRegistration userRegistration = new UserRegistration
            {
                login = txtLogin.Text,
                password = txtPassword.Password,
                repeatPass = txtRepeatPassword.Password,
                email = txtEmail.Text,
                group_User = txtGroup.Text,
                name = txtName.Text,
                lastName = txtLastName.Text,
                surname = txtSurname.Text,
                age = Convert.ToInt32(txtAge.Text),
                dirthDate = txtBirth.Text,
                phoneNumber = txtPhone.Text
            };

            List<string> validationErrors = userRegistration.Validate();

            if (validationErrors.Count > 0)
            {
                DisplayValidationCorrectInputErrors(validationErrors);
            }
            else
            {
                DBConnection.command.ExecuteNonQuery();
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                Close();
            }
            DBConnection.CloseDB();           
        }

        private void ClearValidationEmptyErrors()
        {
            // Очистка ошибок валидации перед новой проверкой
            FieldValidator.ClearEmptyFieldError(txtPassword);
            FieldValidator.ClearEmptyFieldError(txtRepeatPassword);
            FieldValidator.ClearEmptyFieldError(txtLogin);
            FieldValidator.ClearEmptyFieldError(txtName);
            FieldValidator.ClearEmptyFieldError(txtLastName);
            FieldValidator.ClearEmptyFieldError(txtSurname);
            FieldValidator.ClearEmptyFieldError(txtGroup);
            FieldValidator.ClearEmptyFieldError(txtEmail);
            FieldValidator.ClearEmptyFieldError(txtAge);
            FieldValidator.ClearEmptyFieldError(txtPhone);
            FieldValidator.ClearEmptyFieldError(txtBirth);
        }

        private bool HasValidationErrors()
        {
            // Проверка наличия ошибок валидации
            return txtPassword.ToolTip != null ||
                   txtRepeatPassword.ToolTip != null ||
                   txtLogin.ToolTip != null ||
                   txtName.ToolTip != null ||
                   txtLastName.ToolTip != null ||
                   txtSurname.ToolTip != null ||
                   txtGroup.ToolTip != null ||
                   txtEmail.ToolTip != null ||
                   txtAge.ToolTip != null ||
                   txtPhone.ToolTip != null ||
                   txtBirth.ToolTip != null;
        }

        private void DisplayValidationCorrectInputErrors(List<string> errors)
        {
                foreach (string error in errors)
                {
                    switch (error)
                    {
                        case "Пароли не совпадают.":
                        ShowPassInputValidation(txtRepeatPassword, error);
                            break;
                        case "Email должен содержать '@' и '.'.":
                        ShowValidationInputError(txtEmail, error);
                            break;
                        case "Группа должна содержать '-'.":
                        ShowValidationInputError(txtGroup, error);
                            break;
                        case "Пример номера телефона '8-888-888-88-88'.":
                        ShowValidationInputError(txtPhone, error);
                            break;
                        case "Пример даты рождения '01.01.2001'.":
                        ShowValidationInputError(txtBirth, error);
                            break;
                        case "Возраст не может быть выше 92.":
                        ShowValidationInputError(txtAge, error);
                            break;
                        case "Некорректное имя.":
                        ShowValidationInputError(txtName, error);
                            break;
                        case "Некорректная фамилия.":
                        ShowValidationInputError(txtLastName, error);
                            break;
                        case "Некорректное отчество.":
                        ShowValidationInputError(txtSurname, error);
                            break;
                    }
                }           
        }

        private void ShowValidationInputError(TextBox textBox, string error)
        {
            ToolTip toolTip = new ToolTip
            {
                Content = error
            };

            textBox.ToolTip = toolTip;
            textBox.BorderBrush = Brushes.Red;
        }

        private void ShowPassInputValidation(PasswordBox passwordBox, string error)
        {
            ToolTip toolTip = new ToolTip
            {
                Content = error
            };

            passwordBox.ToolTip = toolTip;
            passwordBox.BorderBrush = Brushes.Red;
        }

        private void ClearValidationErrors()
        {
            txtLogin.ToolTip = null;
            txtLogin.ClearValue(BorderBrushProperty); 

            txtPassword.ToolTip = null;
            txtPassword.ClearValue(BorderBrushProperty);

            txtRepeatPassword.ToolTip = null;
            txtRepeatPassword.ClearValue(BorderBrushProperty);

            txtEmail.ToolTip = null;
            txtEmail.ClearValue(BorderBrushProperty);

            txtGroup.ToolTip = null;
            txtGroup.ClearValue(BorderBrushProperty);

            txtName.ToolTip = null;
            txtName.ClearValue(BorderBrushProperty);

            txtLastName.ToolTip = null;
            txtLastName.ClearValue(BorderBrushProperty);

            txtSurname.ToolTip = null;
            txtSurname.ClearValue(BorderBrushProperty);

            txtAge.ToolTip = null;
            txtAge.ClearValue(BorderBrushProperty);

            txtBirth.ToolTip = null;
            txtBirth.ClearValue(BorderBrushProperty);

            txtPhone.ToolTip = null;
            txtPhone.ClearValue(BorderBrushProperty);
        }
    }
}
