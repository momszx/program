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
        #region Segéd média element azért hogy ne legyen több média inditható
        public MediaElement media = new MediaElement();
        #endregion
        public StackPanel egysor = new StackPanel();
        public MainWindow()
        {
            InitializeComponent();
            #region file beolvasás
            StreamReader sr = new StreamReader(@"gombok.csv");
            string sor;
            #endregion
            #region több média egyszerre való lejátszásának elkerülése érdekéban 
            bool zenefut = false;
            #endregion
            int seged = 0;
            

            while ((sor = sr.ReadLine()) != null)
            {
                #region beolvasott file sorainak szétszedése ";" szerint 
                List<string> gombok = new List<string>(sor.Split(';'));
                #endregion
                #region alat távolság beállítása az elemek között
                Thickness thickness = new Thickness(20, 5, 20, 5);
                #endregion

                StackPanel stackPanel;
                #region Elkülönítésre használt sarck panel létrehozása
                StackPanel panel = new StackPanel();
                panel.Name = gombok[0];
                #endregion
                #region gomb létrehozás
                Button b = new Button();
                b.Name = gombok[0];
                b.Content = gombok[1];
                b.Margin = thickness;
                #endregion
                #region media element létrehozás
                MediaElement m = new MediaElement();
                m.Name =gombok[2];
                Uri uri = new Uri(gombok[3]);
                m.Source = uri;
                m.Width = 200;
                m.Margin = thickness;
                m.LoadedBehavior = MediaState.Manual;
                m.Stop();
                #endregion
                #region gomb click event létrehozás
                b.Click += (s, e) =>
                {
                    if (zenefut)
                    {
                        media.Stop();
                    }
                    media = m;
                    zenefut = true;
                    m.Play(); ;
                };
                #endregion
                if (seged == 0)
                {
                    stackPanel= new StackPanel();
                    stackPanel.HorizontalAlignment = HorizontalAlignment.Center;
                    stackPanel.Orientation = Orientation.Horizontal;
                    stackPanel.Name = gombok[0];
                    egysor = stackPanel;
                    minden.Children.Add(egysor);
                }

                egysor.Children.Add(panel);
                #region gomb illetve media element hozzáadás közös stack panelhez 
                panel.Children.Add(m);
                panel.Children.Add(b);
                #endregion
                seged++;
                if (seged == 6)
                {
                    seged = 0;
                }


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
