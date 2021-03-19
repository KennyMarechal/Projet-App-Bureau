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
using MesAPI;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour YoutubeVue.xaml
    /// </summary>
    public partial class YoutubeVue : UserControl
    {
        YoutubeControlleur m_YoutubeControleur;
        public YoutubeVue()
        {
            InitializeComponent();
            m_YoutubeControleur = new YoutubeControlleur(this);
        }
        public void afficherChaineYT(List<YoutubePlaylist> a_ListChaineYT)
        {
            UniGrid.Children.Clear();

            UniGrid.Columns = 2;
            foreach (YoutubePlaylist a_ChanelYT in a_ListChaineYT)
            {
                UniGrid.Children.Add(CreatePanel(a_ChanelYT));
            }
        }
        private TextBlock CreateTextBlock(YoutubePlaylist a_ChanelYT)
        {
            TextBlock t_TextBlock = new TextBlock();

            t_TextBlock.Text = a_ChanelYT.description;
            t_TextBlock.TextWrapping = TextWrapping.Wrap;
            t_TextBlock.FontSize = 12;

            return t_TextBlock;
        }
        private StackPanel CreatePanel(YoutubePlaylist a_ChanelYT)
        {
            StackPanel t_StackPanel = new StackPanel();

            t_StackPanel.Children.Add(CreateBouton(a_ChanelYT));
            t_StackPanel.Children.Add(CreateTextBlock(a_ChanelYT));

            return t_StackPanel;
        }
        private Button CreateBouton(YoutubePlaylist a_ChanelYT)
        {
            Button t_Buuton = new Button();
            t_Buuton.Content = a_ChanelYT.title ;
            t_Buuton.FontSize = 12;
            t_Buuton.Height = 50;
            t_Buuton.Background = new SolidColorBrush(Colors.White);
            t_Buuton.Foreground = new SolidColorBrush(Colors.Black);
            t_Buuton.Click += (object Object, RoutedEventArgs e) => { System.Diagnostics.Process.Start("https://www.youtube.com/channel/" + a_ChanelYT.channelId); };

            return t_Buuton;
        }
        private void Button_ClickSuivant(object sender, RoutedEventArgs e)
        {
            m_YoutubeControleur.PageSuivant();
        }
        private void Button_Click_Precedent(object sender, RoutedEventArgs e)
        {
            m_YoutubeControleur.PagePrecedent();
        }
    }
}
