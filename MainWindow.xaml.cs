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
using System.Windows.Diagnostics;
using System.Diagnostics;

namespace ScrabbleHub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheat_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/Aidan/source/repos/Scrabble/Scrabble/bin/Debug/Scrabble.exe");
        }

        private void btnGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No game version has been installed");
        }

        private void btnGameMcT_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/Aidan/source/repos/ScrabbleWMcT/ScrabbleWMcT/bin/Debug/ScrabbleWMcT.exe");
        }
    }
}
