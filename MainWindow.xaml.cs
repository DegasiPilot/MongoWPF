﻿using System;
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
        }

        public ICharacter Character { get; set; }

        private List<ICharacter> classList = new List<ICharacter>() {new Warrior(), new Rogue(), new Wizard() };

        private void strMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Character.Strength > Character.MinStrength)
                strTB.Text = (--Character.Strength).ToString();
        }

        private void strPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Strength < Character.MaxStrength)
                strTB.Text = (++Character.Strength).ToString();
        }

        private void dexMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Dexterity > Character.MinDexterity)
                dexTB.Text = (--Character.Dexterity).ToString();
        }

        private void dexPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Dexterity < Character.MaxDexterity)
                dexTB.Text = (++Character.Dexterity).ToString();
        }

        private void intMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence > Character.MinIntelligence)
                intTB.Text = (--Character.Intelligence).ToString();
        }

        private void intPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence < Character.MaxIntelligence)
                intTB.Text = (++Character.Intelligence).ToString();
        }

        private void vitMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Vitality > Character.MinVitality)
                vitTB.Text = (--Character.Vitality).ToString();
        }

        private void vitPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Vitality < Character.MaxVitality)
                vitTB.Text = (++Character.Vitality).ToString();
        }

        private void changeClassBackwardBTN_Click(object sender, RoutedEventArgs e)
        {
            int i = classList.IndexOf(Character);
            i = i > 0 ? i-1 : classList.Count - 1;
            Character = classList[i];
            DataContext = null;
            DataContext = Character;
        }

        private void changeClassForwardBTN_Click(object sender, RoutedEventArgs e)
        {
            int i = classList.IndexOf(Character);
            i = i < classList.Count - 1 ? i+1: 0;
            Character = classList[i];
            DataContext = null;
            DataContext = Character;
        }

        private void applyPointsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resetPointsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SubmitClassBtn_Click(object sender, RoutedEventArgs e)
        {
            StatPanel.IsEnabled = true;
            ClassChoisePanel.IsEnabled = false;
        }
    }
}
