using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace MesAPI
{
    class FootControlleur
    {
        private FootVue m_FootVue;
        private FootDAO FootDAO;
        public FootControlleur(FootVue a_FootVue)
        {
            m_FootVue = a_FootVue;
            FootDAO = new FootDAO();

            m_FootVue.afficher(FootDAO.GetMatchs());
        }
    }
}
