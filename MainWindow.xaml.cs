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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Character = classList[0];
            DataContext = Character;
            currentStatPointsAmount = Character.UnSpentedStatPoints;
        }

        public ICharacter Character { get; set; }

        private List<ICharacter> classList = new List<ICharacter>() { new Warrior(), new Rogue(), new Wizard() };

        private int currentStatPointsAmount;
        private int _newStrength;
        private int _newDexterity;
        private int _newIntelligence;
        private int _newVitality;

        private void strMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Strength > Character.MinStrength)
            {
                strTB.Text = (--Character.Strength).ToString();
                statPointsTb.Text = (++currentStatPointsAmount).ToString();
            }
        }

        private void strPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Strength < Character.MaxStrength && currentStatPointsAmount > 0)
            {
                strTB.Text = (++Character.Strength).ToString();
                statPointsTb.Text = (--currentStatPointsAmount).ToString();
            }
        }

        private void dexMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Dexterity > Character.MinDexterity)
            {
                dexTB.Text = (--Character.Dexterity).ToString();
                statPointsTb.Text = (++currentStatPointsAmount).ToString();
            }
        }

        private void dexPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Dexterity < Character.MaxDexterity && currentStatPointsAmount > 0)
            { 
                dexTB.Text = (++Character.Dexterity).ToString();
                statPointsTb.Text = (--currentStatPointsAmount).ToString();
            }
        }

        private void intMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence > Character.MinIntelligence)
            {
                intTB.Text = (--Character.Intelligence).ToString();
                statPointsTb.Text = (++currentStatPointsAmount).ToString();
            }
        }

        private void intPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence < Character.MaxIntelligence && currentStatPointsAmount > 0)
            {
                intTB.Text = (++Character.Intelligence).ToString();
                statPointsTb.Text = (--currentStatPointsAmount).ToString();
            }
        }

        private void vitMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Vitality > Character.MinVitality)
            {
                vitTB.Text = (--Character.Vitality).ToString();
                statPointsTb.Text = (++currentStatPointsAmount).ToString();
            }
        }

        private void vitPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Vitality < Character.MaxVitality && currentStatPointsAmount > 0)
            {
                vitTB.Text = (++Character.Vitality).ToString();
                statPointsTb.Text = (--currentStatPointsAmount).ToString();
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
            DataContext = null;
            DataContext = Character;
        }

        private void resetPointsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SubmitClassBtn_Click(object sender, RoutedEventArgs e)
        {
            StatPanel.IsEnabled = true;
            ClassChoisePanel.IsEnabled = false;
            ExpBtnPanel.IsEnabled = true;
        }

        private void Add100ExpBtn_Click(object sender, RoutedEventArgs e)
        {
            Character.Expirience += 100;
            DataContext = null;
            DataContext = Character;
        }

        private void Add500ExpBtn_Click(object sender, RoutedEventArgs e)
        {
            Character.Expirience += 500;
            DataContext = null;
            DataContext = Character;
        }

        private void Add1000ExpBtn_Click(object sender, RoutedEventArgs e)
        {
            Character.Expirience += 1000;
            DataContext = null;
            DataContext = Character;
        }
    }
}
