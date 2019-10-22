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

namespace Hangman
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void GameStart(object sender, RoutedEventArgs e)
        {
            btnOk.Content = "Mentve";

            int szohossz = psBox.Password.Length;
            for (int i = 0; i < szohossz; i++)
            {
                Label lbl = new Label();
                lbl.Content = "_";
                lbl.Margin = new Thickness(0, 0, 10, 0);
                stpForLabel.Children.Add(lbl);
                
            }
            btnOk.IsEnabled = false;
        }
       


    }
}
