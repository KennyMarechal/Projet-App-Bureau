using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MesAPI
{
    public class YoutubePlaylistDAO
    {
        string url = "https://www.googleapis.com/youtube/v3/subscriptions?part=contentDetails%2Cid%2Csnippet%2CsubscriberSnippet&channelId=UCEP-DhtWifZDbRWzaOsRptQ&pageToken={0}&key=AIzaSyDq8gAG71KfmpHTmIOwlgSDeFsmpCurW-k";
        public List<YoutubePlaylist> GetYoutubePlaylist(string a_PageToken)
        {
            WebRequest webRequest = WebRequest.Create(string.Format(url, a_PageToken));
            WebResponse webResponse = webRequest.GetResponse();

            Stream stream = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);

            string JsonText = streamReader.ReadToEnd();

            List<YoutubePlaylist> playlistArray = new List<YoutubePlaylist>();
          
            dynamic array = JsonConvert.DeserializeObject(JsonText);

            foreach (var x in array.items)
            {
                YoutubePlaylist ytPlaylist = new YoutubePlaylist();

                ytPlaylist.title = x.snippet.title;
                ytPlaylist.description = x.snippet.description;
                ytPlaylist.channelId = x.snippet.resourceId.channelId;

                ytPlaylist.nextPageToken = array.nextPageToken;
                ytPlaylist.prevPageToken = array.prevPageToken;

                playlistArray.Add(ytPlaylist);
            }

            return playlistArray;
        }
    }
}
