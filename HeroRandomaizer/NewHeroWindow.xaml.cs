using HeroRandomaizer.Contexts;
using HeroRandomaizer.Models;
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

namespace HeroRandomaizer
{
    /// <summary>
    /// Interaction logic for NewHeroWindow.xaml
    /// </summary>
    public partial class NewHeroWindow : Window
    {
        private HeroBuilderContext _context;
        private HeroModel _editingHero;

        public NewHeroWindow()
        {
            _context = new HeroBuilderContext();
            InitializeComponent();
            LoadClans();
        }

        public NewHeroWindow(HeroModel heroToEdit) : this()
        {
            _editingHero = heroToEdit;
            LoadHeroData();
        }

        private void LoadClans()
        {
            var clans = _context.Clans.ToList();
            ClanComboBox.ItemsSource = clans;

            var attributes = _context.powerAttributes.ToList();
            AttributeComboBox.ItemsSource = attributes;
        }

        private void LoadHeroData()
        {
            if (_editingHero != null)
            {
                HeroNameTextBox.Text = _editingHero.Name;
                ClanComboBox.SelectedItem = _editingHero.Clan;
                AttributeComboBox.SelectedItem = _editingHero.PowerAttribute;
            }
        }

        private void SaveHeroButton_Click(object sender, RoutedEventArgs e)
        {
            string heroName = HeroNameTextBox.Text;
            var selectedClan = ClanComboBox.SelectedItem as Clans;
            var selectedAttribute = AttributeComboBox.SelectedItem as PowerAttributes;

            if (!string.IsNullOrWhiteSpace(heroName) && selectedClan != null && selectedAttribute != null)
            {
                if (_editingHero == null)
                {
                    var newHero = new HeroModel
                    {
                        Name = heroName,
                        Clan = selectedClan,
                        PowerAttribute = selectedAttribute
                    };
                    _context.Heroes.Add(newHero);
                }
                else
                {
                    _editingHero.Name = heroName;
                    _editingHero.Clan = selectedClan;
                    _editingHero.PowerAttribute = selectedAttribute;
                    _context.Heroes.Update(_editingHero);
                }

                _context.SaveChanges();
                MessageBox.Show("Hero saved successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }
    }
}

