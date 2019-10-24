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
using Microsoft.Win32;
using System.IO;

namespace MemePlayerTerv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(@"gombok.csv");
            string sor;
            while ((sor = sr.ReadLine()) != null)
            {
                List<string> gombok = new List<string>(sor.Split(';'));
                Button b = new Button();
                b.Name = gombok[0];
                b.Content = gombok[1];
                b.Height = 20;
                //b.Width = 30;
                b.Click += (source, e) =>
                {
                    media.Source = gombok[3].; 
                };
                GombokHelye.Children.Add(b);
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            //media.Play();
            btnPlay.IsEnabled = false;
            btnPause.IsEnabled = true;
            btnStop.IsEnabled = true;
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            //media.Pause();
            btnPlay.IsEnabled = true;
            btnPause.IsEnabled = false;
            btnStop.IsEnabled = true;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            //media.Stop();
            btnPlay.IsEnabled = true;
            btnPause.IsEnabled = true;
            btnStop.IsEnabled = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnPause.IsEnabled = false;
            btnPlay.IsEnabled = false;
            btnStop.IsEnabled = false;
            sldVoule.Minimum = 0;
            sldVoule.Maximum = 1;
            //sldVoule.Value = media.Volume = 0.5;
            //lblVolume.Content = media.Volume * 100 + " %";
            
            //try
            //{
            //    using (StreamReader sr = new StreamReader("TestFile.txt"))
            //    {
            //        string line = sr.ReadToEndAsync();
            //        ResultBlock.Text = line;
            //    }
            //}
            //catch (FileNotFoundException ex)
            //{
            //    ResultBlock.Text = ex.Message;
            //}
        }

        private void sldVoule_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //media.Volume = sldVoule.Value;
            lblVolume.Content = (int)(sldVoule.Value * 10) + " %";
        }
    }
}
