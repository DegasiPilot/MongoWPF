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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MongoWPF
{
    /// <summary>
    /// Логика взаимодействия для CharacterRedactorPage.xaml
    /// </summary>
    public partial class CharacterRedactorPage : Page
    {
        public CharacterRedactorPage()
        {
            InitializeComponent();
            WeaponCb.ItemsSource = weaponList;
            if (App.CurrentCharacter == null)
            {
                Character = classList[0];
                App.CurrentCharacter = Character;
            }
            else
            {
                Character = App.CurrentCharacter;
                SubmitClassBtn_Click(null, null);
            }
            WeaponCb.SelectedIndex = (WeaponCb.ItemsSource as List<Weapon>).FindIndex(x => x.Name == Character.Weapon.Name);
            DataContext = Character;
            currentStatPointsAmount = Character.UnSpentedStatPoints;
            _oldStrength = Character.BaseStrength;
            _oldDexterity = Character.BaseDexterity;
            _oldIntelligence = Character.BaseIntelligence;
            _oldVitality = Character.BaseVitality;

            Binding statPointsBinding = new Binding("statPointsAsString");
            statPointsBinding.Source = this;
            BindingOperations.SetBinding(statPointsTb, TextBlock.TextProperty, statPointsBinding);
            BindingExpression statPointsExpression = statPointsTb.GetBindingExpression(TextBlock.TextProperty);

            Binding addExpPanelBinding = new Binding("CanAddExp");
            addExpPanelBinding.Source = this;
            BindingOperations.SetBinding(ExpBtnPanel, IsEnabledProperty, addExpPanelBinding);
            BindingExpression addExpPanelExpression = ExpBtnPanel.GetBindingExpression(IsEnabledProperty);
            DataContextChanged += (object sender, DependencyPropertyChangedEventArgs e) =>
            {
                statPointsExpression.UpdateTarget();
                addExpPanelExpression.UpdateTarget();
            };
        }

        public Character Character { get; set; }

        private List<Character> classList = new List<Character>() { new Warrior(), new Rogue(), new Wizard()};
        private List<Weapon> weaponList = new List<Weapon>() {new Fist(), new Wand()};

        public int currentStatPointsAmount;
        private int _oldStrength;
        private int _oldDexterity;
        private int _oldIntelligence;
        private int _oldVitality;

        public string statPointsAsString => currentStatPointsAmount.ToString();
        public bool CanAddExp => Character.UnSpentedStatPoints == currentStatPointsAmount;

        private void strMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.BaseStrength > _oldStrength)
            {
                Character.BaseStrength--;
                currentStatPointsAmount++;
                DataContext = null;
                DataContext = Character;
            }
        }

        private void strPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.BaseStrength < Character.MaxStrength && currentStatPointsAmount > 0)
            {
                Character.BaseStrength++;
                currentStatPointsAmount--;
                DataContext = null;
                DataContext = Character;
            }
        }

        private void dexMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.BaseDexterity > _oldDexterity)
            {
                Character.BaseDexterity--;
                currentStatPointsAmount++;
                DataContext = null;
                DataContext = Character;
            }
        }

        private void dexPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.BaseDexterity < Character.MaxDexterity && currentStatPointsAmount > 0)
            {
                Character.BaseDexterity++;
                currentStatPointsAmount--;
                ExpBtnPanel.IsEnabled = false;
                DataContext = null;
                DataContext = Character;
            }
        }

        private void intMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.BaseIntelligence > _oldIntelligence)
            {
                Character.BaseIntelligence--;
                currentStatPointsAmount++;
                DataContext = null;
                DataContext = Character;
            }
        }

        private void intPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.BaseIntelligence < Character.MaxIntelligence && currentStatPointsAmount > 0)
            {
                Character.BaseIntelligence++;
                currentStatPointsAmount--;
                DataContext = null;
                DataContext = Character;
            }
        }

        private void vitMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.BaseVitality > _oldVitality)
            {
                Character.BaseVitality--;
                currentStatPointsAmount++;
                DataContext = null;
                DataContext = Character;
            }
        }

        private void vitPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.BaseVitality < Character.MaxVitality && currentStatPointsAmount > 0)
            {
                Character.BaseVitality++;
                currentStatPointsAmount--;
                DataContext = null;
                DataContext = Character;
            }
        }

        private void changeClassBackwardBTN_Click(object sender, RoutedEventArgs e)
        {
            int i = classList.IndexOf(Character);
            i = i > 0 ? i - 1 : classList.Count - 1;
            Character = classList[i];
            DataContext = null;
            DataContext = Character;
        }

        private void changeClassForwardBTN_Click(object sender, RoutedEventArgs e)
        {
            int i = classList.IndexOf(Character);
            i = i < classList.Count - 1 ? i + 1 : 0;
            Character = classList[i];
            DataContext = null;
            DataContext = Character;
        }

        private void applyPointsBtn_Click(object sender, RoutedEventArgs e)
        {
            Character.UnSpentedStatPoints = currentStatPointsAmount;
            _oldStrength = Character.BaseStrength;
            _oldDexterity = Character.BaseDexterity;
            _oldIntelligence = Character.BaseIntelligence;
            _oldVitality = Character.BaseVitality;
            Character.UnSpentedStatPoints = currentStatPointsAmount;

            DataContext = null;
            DataContext = Character;
        }

        private void resetPointsBtn_Click(object sender, RoutedEventArgs e)
        {
            Character.BaseStrength = _oldStrength;
            Character.BaseDexterity = _oldDexterity;
            Character.BaseIntelligence = _oldIntelligence;
            Character.BaseVitality = _oldVitality;
            currentStatPointsAmount = Character.UnSpentedStatPoints;

            DataContext = null;
            DataContext = Character;
        }

        private void SubmitClassBtn_Click(object sender, RoutedEventArgs e)
        {
            StatPanel.IsEnabled = true;
            ClassChoisePanel.IsEnabled = false;
            SaveBtn.IsEnabled = true;
            ResetBtn.IsEnabled = true;
            DeleteBtn.IsEnabled = true;
            WeaponCb.IsEnabled = true;
        }

        private void Add100ExpBtn_Click(object sender, RoutedEventArgs e)
        {
            Character.Expirience += 100;
            OnExpUpdate();
        }

        private void Add500ExpBtn_Click(object sender, RoutedEventArgs e)
        {
            Character.Expirience += 500;
            OnExpUpdate();
        }

        private void Add1000ExpBtn_Click(object sender, RoutedEventArgs e)
        {
            Character.Expirience += 1000;
            OnExpUpdate();
        }

        private void OnExpUpdate()
        {
            currentStatPointsAmount = Character.UnSpentedStatPoints;
            DataContext = null;
            DataContext = Character;
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentCharacter = null;
            App.MainFrame.NavigationService.Refresh();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Name != "")
            {
                var characterAtDb = CRUD.GetCharacter(Character.Id);
                if (characterAtDb != null)
                {
                    CRUD.RedactCharacter(Character);
                    MessageBox.Show("Персонаж успешно изменен!");
                }
                else
                {
                    if (CRUD.IsExistCharacterName(Character.Name))
                    {
                        MessageBox.Show("Имя уже существует! Если вы хотите редактировать существующего персонажа выберите Загрузить");
                    }
                    else
                    {
                        CRUD.CreateCharacter(Character);
                        MessageBox.Show("Персонаж успешно создан!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Имя пустое!");
            }
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Uri("LoadCharacterPage.xaml", UriKind.Relative));
        }

        private void DeleteBtnBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CRUD.TryDeleteCharacter(Character.Id))
            {
                MessageBox.Show("Персонаж успешно удален!");
            }
            else
            {
                MessageBox.Show("Этот персонаж еще не создан!");
            }
        }

        private void WeaponCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character.Weapon = (WeaponCb.SelectedItem as Weapon);
            DataContext = null;
            DataContext = Character;
        }
    }
}
