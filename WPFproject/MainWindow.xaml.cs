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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setupClass prep = new setupClass();
            this.refreshListBox(prep.tamagotchis);
        }

        private void refreshListBox(List<Tamagotchi> tamagotchis)
        {
            tamagotchiListBox.Items.Clear();
            foreach (var tamagotchi in tamagotchis)
            {
                tamagotchiListBox.Items.Add(tamagotchi.name);
            }
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            if (tamagotchiListBox.SelectedItem != null)
            {
                DetailWindow win2 = new DetailWindow((String)tamagotchiListBox.SelectedItem);
                win2.Show();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

    }
}
