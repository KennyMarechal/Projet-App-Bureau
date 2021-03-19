using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            YoutubePlaylistDAO YoutubeDAO = new YoutubePlaylistDAO();
            ChuckNorrisJokesDAO ChuckNorrisJokesDAO = new ChuckNorrisJokesDAO();
            FootDAO FootDAO = new FootDAO();
            ConvertDAO ConvertDAO = new ConvertDAO();
            TimeDAO TimeDAO = new TimeDAO();

            List<YoutubePlaylist> Youtube = YoutubeDAO.GetYoutubePlaylist();
            List<ChuckNorrisJokesRng> ChuckNorrisJokes = ChuckNorrisJokesDAO.GetChuckNorisJokes();
            List<Foot> Match = FootDAO.GetMatchs();
            List<Convert> Convert = ConvertDAO.GetConvert();
            List<Time> time = TimeDAO.GetTime();
        }
    }
}
