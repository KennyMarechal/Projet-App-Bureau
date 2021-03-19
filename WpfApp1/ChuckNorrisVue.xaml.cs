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
    /// Logique d'interaction pour ChuckNorrisVue.xaml
    /// </summary>
    public partial class ChuckNorrisVue : UserControl
    {
        ChuckNorrisControlleur m_ChuckNorris;
        public ChuckNorrisVue()
        {
            InitializeComponent();

            m_ChuckNorris = new ChuckNorrisControlleur(this);
        }

        public void Afficher(List<ChuckNorrisJokesRng> a_Chuck)
        {
            
            Grid.Children.Add(Icon(a_Chuck));
            Jokes.Text = a_Chuck[0].value;
        }

        public Image Icon(List<ChuckNorrisJokesRng> a_Chuck)
        {
            Image t_Image = new Image();

            t_Image.Source = new BitmapImage(new Uri(a_Chuck[0].icon_url));
            t_Image.Width = 100;

            return t_Image;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m_ChuckNorris.ReffrreshClick();
        }
    }
}
