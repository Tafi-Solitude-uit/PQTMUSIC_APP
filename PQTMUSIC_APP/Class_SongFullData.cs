using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQTMUSIC_APP
{
    public class Class_SongFullData
    {
        public string Key { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Duration { get; set; }
        public List<Class_Artist> Artists { get; set; }
        public List<StreamUrl> StreamUrls { get; set; }
    }
}
