using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace MesAPI
{
    class ConvertControlleur
    {
        private ConvertVue m_ConvertVue;
        private ConvertDAO m_ConvertDAO;
        private string m_Input = "1";
        public ConvertControlleur(ConvertVue a_ConvertVue)
        {
            m_ConvertVue = a_ConvertVue;
            m_ConvertDAO = new ConvertDAO();

            m_ConvertVue.Affiche(m_ConvertDAO.GetConvert(m_Input));
        }
        public void Enter(string a_St)
        {
            m_ConvertVue.Affiche(m_ConvertDAO.GetConvert(a_St));
        }
        public string Input
        {
            get { return m_Input; }
            set { m_Input = value; }
        }
    }
}
