using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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

namespace ConferenceApplication.Pages
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            List<string> titles = conferenceEntities.GetContext().events.Select(e => e.title).ToList();
            eventComboBoxField.ItemsSource = titles;
            string idNumberText = idNumberField.Text;
            idNumberField.Text = GenerateIdNumber().ToString();
            idNumberField.IsReadOnly = true;
        }

        private void AcceptButton_onClick(object sender, RoutedEventArgs e)
        {
            List<object> form_data = CollectData();
            CheckFormData(form_data);
        }

        public List<object> CollectData()
        {
            List<object> data = new List<object>();

            string idNumberText = idNumberField.Text;
            int id = Convert.ToInt32(idNumberText);
            data.Add(id);

            string[] initials = InitialField.Text.Split(' ');
            string last_name = initials[0];
            string first_name = initials[1];
            string patronymic = initials[2];
            data.Add(last_name);
            data.Add(first_name);
            data.Add(patronymic);

            TextBlock genderChar = genderChoiceField.SelectedItem as TextBlock;
            if (genderChar != null)
            {
                string gender = genderChar.Text;
                data.Add(gender);
            }

            TextBlock roleTitle = roleChoiceField.SelectedItem as TextBlock;
            if (roleTitle != null)
            {
                string role = roleTitle.Text;
                data.Add(role);
            }

            string email = emailField.Text;
            data.Add(email);

            string telephone_number = telephoneNumberField.Text;
            data.Add(telephone_number);

            string speciality = specialityField.Text;
            data.Add(speciality);

            string password = passphraseField.Password;
            data.Add(password);

            string approvePassword = passphraseApproveField.Password;
            data.Add(approvePassword);

            return data;
        }

        private void CheckFormData(List<object> form_data)
        {
            bool hasEmptyValue = form_data.Any(data => data == null || string.IsNullOrWhiteSpace(data.ToString()));

            if (hasEmptyValue)
            {
                Console.WriteLine("Все поля должны быть заполнены");
            }
            else
            {
                Console.WriteLine("Все поля содержат значения");
            }
        }

        private int GenerateIdNumber()
        {
            Random random = new Random();
            int preparedIdNumber = random.Next(10000, 100000);
            return preparedIdNumber;
        }
    }

    
}
