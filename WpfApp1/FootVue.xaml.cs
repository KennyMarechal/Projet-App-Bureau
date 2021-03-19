using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
using System.Windows.Threading;
using MesAPI;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour FootVue.xaml
    /// </summary>
    public partial class FootVue : UserControl
    {
        FootControlleur m_FootControlleur;
        public FootVue()
        {
            InitializeComponent();

            m_FootControlleur = new FootControlleur(this);

        }
        public void afficher(List<Foot> a_ListFoot)
        {
            MainGrid.Columns = 4;

            foreach (Foot a_Match in a_ListFoot)
            {
                if (a_Match.nameCompetition == "ENGLAND: Premier League" || a_Match.nameCompetition == "FRANCE: Ligue 1" || a_Match.nameCompetition == "SPAIN: La Liga")
                {
                    MainGrid.Children.Add(CreerGrid(a_Match));
                }              
            }
        }
        private Button CreateBouton(Foot a_Match)
        {
            Button t_Buuton = new Button();
            t_Buuton.Content = a_Match.title +" \nDate : "+ a_Match.date;
            t_Buuton.FontSize = 12;
            t_Buuton.Height = 50;
            t_Buuton.Background = new SolidColorBrush(Colors.White);
            t_Buuton.Foreground = new SolidColorBrush(Colors.Black);
            t_Buuton.Click += (object Object, RoutedEventArgs e) => { System.Diagnostics.Process.Start(a_Match.url); };

            return t_Buuton;
        }
        private Button CreateBoutonVideo(Foot a_Match)
        {
            Button t_Buuton = new Button();
            t_Buuton.Content = "Lien vers Vidéos";
            t_Buuton.FontSize = 12;
            t_Buuton.Height = 50;
            t_Buuton.Background = new SolidColorBrush(Colors.White);
            t_Buuton.Foreground = new SolidColorBrush(Colors.Black);
            t_Buuton.Click += (object Object, RoutedEventArgs e) => {System.Diagnostics.Process.Start(a_Match.lienVideo);};

            return t_Buuton;
        }
        private Grid CreerGrid(Foot a_Match)
        {
            Grid t_Grid = new Grid();
            t_Grid.Children.Add(CreatePanel(a_Match));
            Canvas.SetZIndex(t_Grid, -1);

            return t_Grid;
        }
        private StackPanel CreatePanel(Foot a_Match)
        {
            StackPanel t_StackPanel = new StackPanel();

            t_StackPanel.Children.Add(CreateBouton(a_Match));
            t_StackPanel.Children.Add(CreateBoutonVideo(a_Match));

            return t_StackPanel;
        }
    }
}
