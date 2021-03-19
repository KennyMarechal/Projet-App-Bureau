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
    /// Logique d'interaction pour TimeVue.xaml
    /// </summary>
    public partial class TimeVue : UserControl
    {
        TimeControlleur m_TimeControlleur;
        public TimeVue()
        {
            InitializeComponent();
            m_TimeControlleur = new TimeControlleur(this);
            m_TimeControlleur.ReffrreshClick();
        }

        public void Afficher(List<Time> a_ListTime)
        {
            AfficheJour.Text = a_ListTime[0].dayOfTheWeek;
            AfficherHeure.Text = a_ListTime[0].currentDateTime;
            AfficherUTC.Text = a_ListTime[0].utcOffset;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m_TimeControlleur.ReffrreshClick();
        }
    }
}
