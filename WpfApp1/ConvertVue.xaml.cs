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
    /// Logique d'interaction pour ConvertVue.xaml
    /// </summary>
    public partial class ConvertVue : UserControl
    {
        ConvertControlleur m_Convert;
        public string amount = "";
        public ConvertVue()
        {
            InitializeComponent();
            m_Convert = new ConvertControlleur(this);
        }

        public void Affiche(List<ConvertMonnaie> a_ListConvert)
        {
            amount = "500";
            AfficheConvert.Text = a_ListConvert[0].rate_for_amount;
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            m_Convert.Input = Enter.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m_Convert.Enter(Enter.Text);
        }
    }
}
