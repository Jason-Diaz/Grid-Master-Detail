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

namespace Lab_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VideoGame Game = new VideoGame();
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            count++;
            textboxCount.Text = count.ToString();
        }

        private void listviewMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGame x;
            x = (VideoGame)e.AddedItems[0];

            textboxGameName.Text = x.GameName;
            textboxRating.Text = x.Rating;
            textboxPrice.Text = x.Price.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game.GameName = textboxGameName.Text;
            Game.Rating = textboxRating.Text;
            Game.Price = double.Parse(textboxPrice.Text);
            listviewMain.Items.Add(Game);

            textboxGameName.Text = String.Empty;
            textboxPrice.Text = String.Empty;
            textboxRating.Text = String.Empty;
            textboxGameName.Focus();

            textboxCount.Text = (listviewMain.Items.Count).ToString();
        }

        private void textboxCount_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }
    }
}
