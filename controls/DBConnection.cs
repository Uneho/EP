using System;
using System.Windows;
using System.Configuration;
using System.Data.SqlClient;

namespace EducationPortal.controls
{
    public class DBConnection
    {
        static string DBConnect = ConfigurationManager.ConnectionStrings["testConnection"].ConnectionString;
        static public SqlDataAdapter dataAdapter;
        static public SqlConnection myconnect;
        static public SqlCommand command;

        public static bool ConnectionDB()
        {
            try
            {
                myconnect = new SqlConnection(DBConnect);
                myconnect.Open();
                command = new SqlCommand();
                command.Connection = myconnect;
                dataAdapter = new SqlDataAdapter(command);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ошибка соединения с бд", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        public static void CloseDB()
        {
            myconnect.Close();
        }

        public SqlConnection GetConnection()
        {
            return myconnect;
        }
    }
}
