using ROG_6.Model;
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

namespace WPFproject
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public setupClass prep { get; set; }
        public Tamagotchi tamagotchi { get; set; }

        public DetailWindow()
        {
            InitializeComponent();
            prep = new setupClass();
        }

        public DetailWindow(String tamagotchiName)
        {
            InitializeComponent();
            prep = new setupClass();
            tamagotchi = prep.getByName(tamagotchiName);

            this.refresh();
        }

        private void refresh()
        {
            if (tamagotchi != null)
            {
                NameCounterLabel.Content = tamagotchi.name;
                HealthCounterLabel.Content = tamagotchi.health;
                SleepCounterLabel.Content = tamagotchi.sleep;
                HungerCounterLabel.Content = tamagotchi.hunger;
                BoredomCounterLabel.Content = tamagotchi.boredom;
                StatusCounterLabel.Content = prep.statusToString(tamagotchi);
            }
        }

        void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            // Show message box when button is clicked  
            MessageBox.Show("Hello, Windows Presentation Foundation!");
        }
    }
}
