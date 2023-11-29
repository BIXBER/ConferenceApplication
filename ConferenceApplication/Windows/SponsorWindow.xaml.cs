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
using ConferenceApplication.Pages;
using Microsoft.IdentityModel.Tokens;

namespace ConferenceApplication.Windows
{
    /// <summary>
    /// Логика взаимодействия для SponsorWindow.xaml
    /// </summary>
    public partial class SponsorWindow : Window
    {
        public string firstName { get; set; }
        public string gender { get; set;}
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public const string MALE = "M";
        public const string FEMALE = "F";

        public SponsorWindow()
        {
            InitializeComponent();
            Console.WriteLine(FirstName);
            Greeting.Content = GreetingTimeText();
            NameGreeting.Content = GreetingNameText();
            
        }
        private string GreetingTimeText()
        {
            DateTime currentTime = DateTime.Now;

            switch (currentTime.Hour)
            {
                case int hour when hour < 11:
                    return "Доброе утро";
                case int hour when hour < 18:
                    return "Добрый день!";
                default:
                    return "Добрый вечер!";
            }
        }

        private string GreetingNameText()
        {
            if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(Gender))
            {
                switch (Gender)
                {
                    case string gender when gender == MALE:
                        return $"Mr. {FirstName}";
                    case string gender when gender == FEMALE:
                        return $"Mrs. {FirstName}";
                    default:
                        return $"{FirstName}";
                }

            }
            return "NoName";
        }
    }
}
