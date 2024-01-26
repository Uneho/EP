using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EducationPortal.controls
{
    public class UserRegistration : DBConnection
    {
        public string login { get; set; }
        public string password { get; set; }
        public string repeatPass { get; set; }
        public string email { get; set; }
        public string group_User { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string dirthDate { get; set; }
        public string phoneNumber { get; set; }

        public List<string> Validate()
        {
            List<string> errors = new List<string>();

            //input
            ValidateField(() => !string.IsNullOrEmpty(login), "Логин не может быть пустым.", errors);
            ValidateField(() => !string.IsNullOrEmpty(password), "Пароль не может быть пустым.", errors);
            ValidateField(() => !string.IsNullOrEmpty(repeatPass) && password == repeatPass, "Пароли не совпадают.", errors);
            ValidateField(() => !string.IsNullOrEmpty(email) && email.Contains("."), "Email должен содержать '@' и '.'.", errors);
            ValidateField(() => !string.IsNullOrEmpty(group_User) && group_User.Contains("-"), "Группа должна содержать '-'.", errors);
            ValidateField(() => ValidateRussian(name), "Некорректное имя.", errors);
            ValidateField(() => ValidateRussian(lastName), "Некорректная фамилия.", errors);
            ValidateField(() => ValidateRussian(surname), "Некорректное отчество.", errors);
            ValidateField(() => age <= 92, "Возраст не может быть выше 92.", errors);
            ValidateField(() => !string.IsNullOrEmpty(dirthDate) && dirthDate.Contains("."), "Пример даты рождения '01.01.2001'.", errors);
            ValidateField(() => !string.IsNullOrEmpty(phoneNumber) && phoneNumber.Contains("-"), "Пример номера телефона '8-888-888-88-88'.", errors);

            // Если есть ошибки, вернуть их
            if (errors.Count > 0)
            {
                return errors;
            }

            //скрипт для сохранения данных в базу данных
            ExecuteSqlScript();

            return errors; // чтобы не возвращать ошибки после регистрации
        }

        private void ValidateField(Func<bool> condition, string errorMessage, List<string> errors) //condition - состояние
        {
            if (!condition())
            {
                errors.Add(errorMessage);
            }
        }

        private bool ValidateRussian(string input)
        {
            return string.IsNullOrEmpty(input) || Regex.IsMatch(input, "^[а-яА-ЯёЁ]+$");
        }

        public void ExecuteSqlScript()
        {
            command.CommandText = $"INSERT INTO account (login, password, email_user, group_user, firstName_user, lastName_user, age_user, birth_user, phone_user, surname_user)" +
            $"VALUES ('{login}', '{password}', '{email}', '{group_User}', '{name}', '{lastName}', '{surname}', '{age}', '{dirthDate}', '{phoneNumber}')";
        }
    }
}
