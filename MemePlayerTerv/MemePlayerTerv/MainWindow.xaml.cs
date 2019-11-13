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
        public MediaElement media = new MediaElement();
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(@"gombok.csv");
            string sor;

            while ((sor = sr.ReadLine()) != null)
            {
                int seged = 0;
                List<string> gombok = new List<string>(sor.Split(';'));
                Thickness thickness = new Thickness(20, 5, 20, 5);
                if (seged == 6)
                {
                    StackPanel egysor = new StackPanel();
                    DockPanel_.Children.Add(egysor);
                }
                StackPanel panel = new StackPanel();
                panel.Name = gombok[0];
                Button b = new Button();
                b.Name = gombok[0];
                b.Content = gombok[1];
                b.Margin = thickness;
                MediaElement m = new MediaElement();
                m.Name = gombok[2];
                Uri uri = new Uri("D:/Git/program/MemePlayerTerv/MemePlayerTerv/bin/Debug/Video/Rick.mp4");
                m.Source = uri;
                m.Width = 200;
                m.Margin = thickness;
                m.LoadedBehavior = MediaState.Manual;
                m.Stop();
                b.Click += (s, e) =>
                {
                    media = m;
                    m.Play();
                };
                
                egysor.Children.Add(panel);
                panel.Children.Add(m);
                panel.Children.Add(b);


            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
            
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
            
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            sldVoule.Minimum = 0;
            sldVoule.Maximum = 1;
            sldVoule.Value = media.Volume = 0.5;
            lblVolume.Content = media.Volume * 100 + " %";

        }

        private void sldVoule_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            media.Volume = sldVoule.Value;
            lblVolume.Content = (int)(sldVoule.Value * 10) + " %";
        }
    }
}
