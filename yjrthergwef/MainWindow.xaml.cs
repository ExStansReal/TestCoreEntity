using System;
using System.Collections.Generic;
using System.IO;
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
using yjrthergwef.Entity;

namespace yjrthergwef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBasedChatContext entity = new DataBasedChatContext();
        public MainWindow()
        {
            InitializeComponent();
            UpdateData();
            Images.Items.Add("MTyjPAINcp0");
        }

        private void UpdateData()
        {
            List<User> users = entity.User.ToList();

            Messages.ItemsSource = users;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Messages.SelectedItem != null)
            {
                MessageBox.Show((Messages.SelectedItem as User).Familiya);
            }
            UpdateData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            User user = new User() { Familiya = aboba.Text, Otchestvo = "hegwefqwd", Ima = "jtehwgeq", Login = "123", Password = "321", Photo = $@"{Directory.GetCurrentDirectory()}\{Images.SelectedItem}.jpg"};
        

            entity.User.Add(user);
            entity.SaveChanges();
            UpdateData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateData();

            User user = Messages.SelectedItem as User;
            user.Familiya = aboba.Text;
            entity.User.Update(user);
            entity.SaveChanges();
            UpdateData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            User user = Messages.SelectedItem as User;
            entity.User.Remove(user);
            entity.SaveChanges();
            UpdateData();
        }
    }
}
