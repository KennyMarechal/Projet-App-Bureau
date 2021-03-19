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
using WpfApp1.Controlleur;
using MesAPI;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WindowsMainControlleur m_MainControlleur;
        private string m_Heure;
        public MainWindow()
        {
            InitializeComponent();
            m_MainControlleur = new WindowsMainControlleur(this);
        }
        public void afficheH(List<Time> a_Time)
        {
            string t_Heure = a_Time[0].currentDateTime;
            string[] t_Splitt = t_Heure.Split('T');
            string t_SplittH = t_Splitt[1];
            string[] t_HeureSplitter = t_SplittH.Split('-');
            m_Heure = t_HeureSplitter[0];

            Heure.Text = m_Heure;
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Youtube":
                    usc = new YoutubeVue();
                    GridMain.Children.Add(usc);
                    break;
                case "FootMatch":
                    usc = new FootVue();
                    GridMain.Children.Add(usc);
                    break;
                case "ChuckNorris":
                    usc = new ChuckNorrisVue();
                    GridMain.Children.Add(usc);
                    break;
                case "Convert":
                    usc = new ConvertVue();
                    GridMain.Children.Add(usc);
                    break;
                case "Time":
                    usc = new TimeVue();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }
        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Button_ClickYT(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Add(new YoutubeVue());
        }
        private void Button_ClickFoot(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Add(new FootVue());
        }
        private void Button_ClickConvert(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Add(new ConvertVue());
        }
        private void Button_Click_Chuck(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Add(new ChuckNorrisVue());
        }
    }
}

