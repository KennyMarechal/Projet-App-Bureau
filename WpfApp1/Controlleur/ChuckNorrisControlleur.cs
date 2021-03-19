using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace MesAPI
{
    public class ChuckNorrisControlleur
    {
        private ChuckNorrisVue m_Chuck;
        private ChuckNorrisJokesDAO ChuckDAO;
        public ChuckNorrisControlleur(ChuckNorrisVue a_Chuck)
        {
            m_Chuck = a_Chuck;
            ChuckDAO = new ChuckNorrisJokesDAO();

            m_Chuck.Afficher(ChuckDAO.GetChuckNorisJokes());
        }

        public void ReffrreshClick()
        {
            m_Chuck.Afficher(ChuckDAO.GetChuckNorisJokes());
        }
    }
}
