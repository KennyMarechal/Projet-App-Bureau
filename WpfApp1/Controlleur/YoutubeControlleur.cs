using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace MesAPI
{
    class YoutubeControlleur
    {
        private YoutubeVue m_YoutubeVue;
        private YoutubePlaylistDAO m_YoutubeDAO;

        private string m_NextPageToken;
        private string m_PrevPageToken;

        public YoutubeControlleur(YoutubeVue a_YoutubeVue)
        {
            m_YoutubeVue = a_YoutubeVue;


            m_YoutubeDAO = new YoutubePlaylistDAO();

            var t_Playlist = m_YoutubeDAO.GetYoutubePlaylist("");

            m_NextPageToken = t_Playlist.First()?.nextPageToken;
            m_PrevPageToken = t_Playlist.First()?.prevPageToken;

            m_YoutubeVue.afficherChaineYT(t_Playlist);
        }
        public void PageSuivant()
        {
            var t_Playlist = m_YoutubeDAO.GetYoutubePlaylist(m_NextPageToken);
            m_YoutubeVue.afficherChaineYT(t_Playlist);

            m_NextPageToken = t_Playlist.First()?.nextPageToken;
            m_PrevPageToken = t_Playlist.First()?.prevPageToken;
        }
        public void PagePrecedent()
        {
            var t_Playlist = m_YoutubeDAO.GetYoutubePlaylist(m_PrevPageToken);
            m_YoutubeVue.afficherChaineYT(t_Playlist);

            m_NextPageToken = t_Playlist.First()?.nextPageToken;
            m_PrevPageToken = t_Playlist.First()?.prevPageToken;
        }
    }
}
