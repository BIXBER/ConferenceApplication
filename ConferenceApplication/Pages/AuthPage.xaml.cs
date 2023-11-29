using ConferenceApplication.Windows;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Application;

namespace ConferenceApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void ButtonRegistration_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new RegistrationPage());
        }

        private void enteringButton_Click(object sender, RoutedEventArgs e)

        {
            string login = IdField.Text;
            string password = passwordField.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            int id = Convert.ToInt32(login);
            using (var db = new conferenceEntities())
            {
                var members = db.members.FirstOrDefault(
                    m => m.member_id == id && m.password == password);
                var sponsors = db.sponsors.FirstOrDefault(
                    sp => sp.sponsor_id == id && sp.password == password);
                var jury = db.jury.FirstOrDefault(
                    j => j.jury_id == id && j.password == password);
                var moderators = db.moderators.FirstOrDefault(
                    moder => moder.moderator_id == id && moder.password == password);
                if (members != null || sponsors != null || jury != null || moderators != null)
                {
                    SponsorWindow mainWindow = new SponsorWindow();
                    if (members != null)
                    {
                        mainWindow.FirstName = members.first_name;
                        mainWindow.Gender = members.gender;
                    }

                    if (jury != null)
                    {
                        mainWindow.FirstName = jury.first_name;
                        mainWindow.Gender = jury.gender;
                        Console.WriteLine(jury.first_name + jury.gender);
                    }

                    if (moderators != null)
                    {
                        mainWindow.FirstName = moderators.first_name;
                        mainWindow.Gender = moderators.gender;
                    }

                    if (sponsors != null)
                    {
                        mainWindow.FirstName = sponsors.first_name;
                        mainWindow.Gender = sponsors.gender;
                    }
                    mainWindow.Show();
                    Window currentWindow = Application.Current.MainWindow;
                    currentWindow.Close();
                }

                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }

        }
    }
}

