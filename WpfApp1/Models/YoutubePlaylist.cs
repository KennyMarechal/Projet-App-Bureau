using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesAPI
{
    public class YoutubePlaylist
    {
        public string title { get; set; }
        public string description { get; set; }
        public string channelId { get; set; }
        public string nextPageToken { get; set; }
        public string prevPageToken { get; set; }
    }
}
