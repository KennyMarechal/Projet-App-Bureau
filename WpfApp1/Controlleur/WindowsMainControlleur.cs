using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesAPI;

namespace WpfApp1.Controlleur
{
    public class WindowsMainControlleur
    {
        private MainWindow m_MainVue;
        private YoutubePlaylistDAO m_ChaineYTDAO;
        private FootDAO m_MatchDAO;
        private ConvertDAO m_ConvertisseurDAO;
        private ChuckNorrisJokesDAO m_NorrisDAO;
        private TimeDAO m_HeureDAO;
        public WindowsMainControlleur(MainWindow a_MainVue)
        {
            m_MainVue = a_MainVue;

            m_MatchDAO = new FootDAO();
            m_ChaineYTDAO = new YoutubePlaylistDAO();
            m_ConvertisseurDAO = new ConvertDAO();
            m_NorrisDAO = new ChuckNorrisJokesDAO();
            m_HeureDAO = new TimeDAO();

            m_MainVue.afficheH(m_HeureDAO.GetTime());
        }
    }
}
