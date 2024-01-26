using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EducationPortal.controls
{
    public class FieldValidator
    {
        public static void ShowEmptyFieldError(FrameworkElement element, string fieldName)
        {
            if (IsEmpty(element))
            {
                ShowValidationEmptyError(element, $"{fieldName} не может быть пустым.");
            }
        }

        public static void ClearEmptyFieldError(FrameworkElement element)
        {
            ClearValidationEmptyError(element);
        }

        private static bool IsEmpty(FrameworkElement element)
        {
            if (element is TextBox textBox)
            {
                return string.IsNullOrEmpty(textBox.Text);
            }
            else if (element is PasswordBox passwordBox)
            {
                return passwordBox.SecurePassword.Length == 0;
            }
            else if (element is TextBlock textBlock)
            {
                return string.IsNullOrEmpty(textBlock.Text);
            }
            else if (element is ComboBox comboBox)
            {
                return comboBox.SelectedItem == null;
            }

            return false;
        }

        private static void ShowValidationEmptyError(FrameworkElement element, string error)
        {
            ToolTip toolTip = new ToolTip
            {
                Content = error
            };

            element.ToolTip = toolTip;
        }

        private static void ClearValidationEmptyError(FrameworkElement element)
        {
            element.ToolTip = null;
        }
    }
}
