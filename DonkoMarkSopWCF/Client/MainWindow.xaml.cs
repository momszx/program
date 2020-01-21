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
using System.ServiceModel;
using Client.MusicService;

namespace Client {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        MusicServiceClient client;
        string uID = string.Empty;

        public MainWindow() {
            InitializeComponent();
            GridLogin.Visibility = Visibility.Visible;
            GridMenu.Visibility = Visibility.Hidden;
            GridAdd.Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            client = new MusicServiceClient();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            try {
                if (LoggedIn() && uID != "WRONG_LOGIN_INFO") {
                    uID = string.Empty;
                    client.Logout(uID);
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLogin_Click(object sender, RoutedEventArgs e) {
            try {
                lbMessege.Content = "";
                if (!LoggedIn()) {
                    uID = client.Login(tbUsername.Text, tbPassword.Password);
                    if (uID != "WRONG_LOGIN_INFO") {
                        GridLogin.Visibility = Visibility.Hidden;
                        GridMenu.Visibility = Visibility.Visible;

                        lbMessege.Content = "Kérlek add meg a felhasználóneved és a jelszót!";

                        ListItems();

                    } else {
                        uID = string.Empty;
                        lbMessege.Content = "Rossz felhasználónév vagy jelszó";
                    }
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLogout_Click(object sender, RoutedEventArgs e) {
            try {
                if (LoggedIn()) {
                    uID = string.Empty;
                    client.Logout(uID);
                    lbMessege.Content = "Kérlek add meg a felhasználóneved és a jelszót!";
                    GridMenu.Visibility = Visibility.Hidden;
                    GridLogin.Visibility = Visibility.Visible;
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRefresh_Click(object sender, RoutedEventArgs e) {
            try {
                if (LoggedIn()) {
                    ListItems();
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, RoutedEventArgs e) {
            try {
                if (LoggedIn()) {
                    Music music = (Music)dgList.SelectedItem;
                    if (music != null) {
                        if (client.Delete(music.Id, uID)) {
                            ListItems();
                        } else MessageBox.Show("Sikertelen törlés");
                    }
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e) {
            try {
                if (LoggedIn()) {
                    GridMenu.Visibility = Visibility.Hidden;
                    GridAdd.Visibility = Visibility.Visible;
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancel_Click(object sender, RoutedEventArgs e) {
            try {
                if (LoggedIn()) {

                    tbMusicName.Text = "";
                    tbMusicLink.Text = "";

                    GridAdd.Visibility = Visibility.Hidden;
                    GridMenu.Visibility = Visibility.Visible;
                    ListItems();
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddMusic_Click(object sender, RoutedEventArgs e) {
            try {
                if (LoggedIn()) {
                    string musicName = tbMusicName.Text, musicLink = tbMusicLink.Text;
                    if (musicName.Length > 0 && musicLink.Length > 0) {
                        if (client.Add(musicName, musicLink, uID)) {
                            tbMusicName.Text = "";
                            tbMusicLink.Text = "";
                            ListItems();
                            GridAdd.Visibility = Visibility.Hidden;
                            GridMenu.Visibility = Visibility.Visible;
                        } else MessageBox.Show("Hiba hozzáadás közben!");
                    } else MessageBox.Show("Minden mezőt kötelező kitölteni!");
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private bool LoggedIn() {
            return uID != string.Empty;
        }

        private void ListItems() {
            try {
                if (LoggedIn()) {
                    List<Music> Musics = client.List(uID).ToList<Music>();
                    dgList.ItemsSource = Musics;
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Detail.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btLike_Click(object sender, RoutedEventArgs e) {
            try {
                if (LoggedIn()) {
                    Music music = (Music)dgList.SelectedItem;
                    if (music != null) {
                        bool? likeState = client.getLike(music.Id, uID);
                        if (likeState != true) {
                            client.Like(music.Id, uID);
                            music.Like += 1;
                            music.Dislike -= (uint)(likeState == false ? 1 : 0);
                        } else MessageBox.Show("Már like-oltad ezt a zenét!");
                    }
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDislike_Click(object sender, RoutedEventArgs e) {
            try {
                if (LoggedIn()) {
                    Music music = (Music)dgList.SelectedItem;
                    if (music != null) {
                        bool? likeState = client.getLike(music.Id, uID);
                        if (likeState != false) {
                            client.Dislike(music.Id, uID);
                            music.Dislike += 1;
                            music.Like -= (uint)(likeState == true ? 1 : 0);
                        } else MessageBox.Show("Már dislike-oltad ezt a zenét!");
                    }
                }
            } catch (FaultException<MyException> ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
