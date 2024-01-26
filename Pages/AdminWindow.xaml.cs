using EducationPortal.controls;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Collections.Generic;

namespace EducationPortal
{
    public partial class AdminWindow : Window
    {
        private bool isAnimating = false; // Флаг, указывающий на состояние анимации
        private double previousWidth = 0; // Переменная для хранения предыдущей ширины `Border`

        private readonly string connectionString = "Data Source=DESKTOP-E3FRCRH;Initial Catalog=testDB;Integrated Security=True";

        public AdminWindow()
        {
            InitializeComponent();
        }     
       
        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            DBConnection.ConnectionDB();
        }

        private void Image_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }


        //animatedBorder
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Если анимация уже выполняется, игнорируем повторное нажатие
            if (isAnimating)
            {
                return;
            }

            // Устанавливаем начальную и конечную ширину для анимации
            double startWidth;
            double endWidth;

            // Проверяем текущее положение `Border`
            if (borderIcon.Width == 40)
            {
                // `Border` в исходном положении, устанавливаем значения для увеличения
                startWidth = borderIcon.ActualWidth;
                endWidth = borderIcon.ActualWidth + 180;
                textName.Visibility = Visibility.Visible;
                textGroup.Visibility = Visibility.Visible;
                textGroupNumber.Visibility = Visibility.Visible;
                textEmail.Visibility = Visibility.Visible;
                txtEmail.Visibility = Visibility.Visible;
                textQuallity.Visibility = Visibility.Visible;
                txtQuallity.Visibility = Visibility.Visible;
                textPhoneNumber.Visibility = Visibility.Visible;
                txtPhoneNumber.Visibility = Visibility.Visible;
            }
            else
            {
                // `Border` уже увеличен, устанавливаем значения для возврата
                startWidth = borderIcon.ActualWidth;
                endWidth = borderIcon.ActualWidth - 180;
                textName.Visibility= Visibility.Hidden;
                textGroup.Visibility= Visibility.Hidden;
                textGroupNumber.Visibility= Visibility.Hidden;
                textEmail.Visibility= Visibility.Hidden;
                txtEmail.Visibility= Visibility.Hidden;
                textQuallity.Visibility= Visibility.Hidden;
                txtQuallity.Visibility= Visibility.Hidden;
                textPhoneNumber.Visibility= Visibility.Hidden;
                txtPhoneNumber.Visibility= Visibility.Hidden;
            }

            // Создаем и настраиваем анимацию ширины
            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.Duration = TimeSpan.FromSeconds(0.4); // Установите желаемую продолжительность анимации
            widthAnimation.From = startWidth;
            widthAnimation.To = endWidth;

            // Создаем и настраиваем аниматор
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(widthAnimation); // анимация ширины в аниматор
            Storyboard.SetTargetProperty(widthAnimation, new PropertyPath("Width")); // свойство анимации

            // Обработчик события завершения анимации
            storyboard.Completed += (s, _) =>
            {
                isAnimating = false; // Сбрасываем флаг анимации
                previousWidth = borderIcon.Width; // Сохраняем текущую ширину в предыдущей переменной
            };

            // Запускаем анимацию
            isAnimating = true; // флаг анимации
            storyboard.Begin(borderIcon); // Запускаем аниматор и применяем его к `Border`
        }


        //input
        private void textSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textSearch.Text) && textSearch.Text.Length > 0)
                textSearch.Visibility = Visibility.Collapsed;
            else
                textSearch.Visibility = Visibility.Visible;
        }

        private void Button_To_Log_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void selectGroupAndSublect_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
