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
    /// Logique d'interaction pour webBrowser.xaml
    /// </summary>
    public partial class webBrowser : UserControl
    {
        public webBrowser(Foot a_Match)
        {
            InitializeComponent();
            test.Source = new Uri(a_Match.lienVideo);
        }
    }
}
