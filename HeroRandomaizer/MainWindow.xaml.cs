using HeroRandomaizer.Contexts;
using HeroRandomaizer.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeroRandomaizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HeroBuilderContext _context;

        public MainWindow()
        {
            _context = new HeroBuilderContext();
            InitializeComponent();
            LoadHeroes();
        }

        private void LoadHeroes()
        {
            var allHeroes = _context.Heroes.Include(h => h.Clan).Include(h => h.PowerAttribute).ToList();
            HeroesListBox.ItemsSource = allHeroes;
            _context.ChangeTracker.Clear();
        }

        private void CreateHeroButton_Click(object sender, RoutedEventArgs e)
        {
            NewHeroWindow newHeroWindow = new NewHeroWindow();
            newHeroWindow.ShowDialog();
            LoadHeroes();
        }
        private void EditHeroButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button?.Tag is int heroId)
            {
                var hero = _context.Heroes.Include(h => h.Clan).Include(h => h.PowerAttribute).FirstOrDefault(h => h.HeroId == heroId);
                if (hero != null)
                {
                    NewHeroWindow editHeroWindow = new NewHeroWindow(hero);
                    editHeroWindow.ShowDialog();
                    LoadHeroes();
                }
            }
        }

        private void DeleteHeroButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button?.Tag is int heroId)
            {
                var hero = _context.Heroes.FirstOrDefault(h => h.HeroId == heroId);
                if (hero != null)
                {
                    _context.Heroes.Remove(hero);
                    _context.SaveChanges();
                    MessageBox.Show($"Hero {hero.Name} has been deleted.");
                    LoadHeroes();
                }
            }

        }
    }
}