using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace MesAPI
{
    public class TimeControlleur
    {
        private TimeVue m_Time;
        private TimeDAO TimeDAO;
        public TimeControlleur(TimeVue a_Time)
        {
            m_Time = a_Time;
            TimeDAO = new TimeDAO();

            m_Time.Afficher(TimeDAO.GetTime());
        }
        public void ReffrreshClick()
        {
            m_Time.Afficher(TimeDAO.GetTime());
        }
    }
}
