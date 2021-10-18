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
using TextManipLibrary;

namespace WPFNameApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public TextManipulator TM = new TextManipulator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = $"{firstNameBox.Text} {lastNameBox.Text}";
        }

        private void reverseButton_Click(object sender, RoutedEventArgs e)
        {
            string reversed = TM.reverseText($"{firstNameBox.Text} {lastNameBox.Text}");
            textDisplay.Text = reversed;
        }
        
        private void shuffleButton_Click(object sender, RoutedEventArgs e)
        {
            string shuffled = TM.shuffleText($"{firstNameBox.Text} {lastNameBox.Text}");
            textDisplay.Text = shuffled;
        }
    }
}
