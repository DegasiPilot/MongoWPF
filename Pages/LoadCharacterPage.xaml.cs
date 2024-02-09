using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MongoWPF
{
    /// <summary>
    /// Логика взаимодействия для LoadCharacterPage.xaml
    /// </summary>
    public partial class LoadCharacterPage : Page
    {
        public LoadCharacterPage()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            var character = CRUD.GetCharacter(CharacterNameTb.Text);
            if(character == null)
            {
                MessageBox.Show("Персонажа с таким ником не существует!");
            }
            else
            {
                App.CurrentCharacter = character;
                App.MainFrame.Navigate(new Uri("Pages/CharacterRedactorPage.xaml", UriKind.Relative));
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Uri("Pages/CharacterRedactorPage.xaml", UriKind.Relative));
        }
    }
}
