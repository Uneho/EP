using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EducationPortal.controls
{
    internal class UserAuthorization
    {
        static public string Role, firstName, User;

        static public void AuthorizationFunc(string login, string password)
        {
            try
            {
                DBConnection.command.CommandText = @"SELECT name_role from sp_role, account WHERE Login = '" + login + "' and password = '" + password + "' and " +
                    "account.id_role=sp_role.id_role ";
                object result = DBConnection.command.ExecuteScalar();

                if (result != null)
                {
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    Role = null;
                    firstName = null;
                }
            }
            catch
            {
                Role = User = null;
                MessageBox.Show("Ошибка при авторизации", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        static public string AuthorizationName(string login)
        {
            try
            {
                DBConnection.command.CommandText = @"SELECT firstName_user FROM account WHERE Login = '" + login + "' ";
                object result = DBConnection.command.ExecuteScalar();
                firstName = result.ToString();
                return firstName;
            }
            catch
            {
                return null;
            }
        }
    }
}
