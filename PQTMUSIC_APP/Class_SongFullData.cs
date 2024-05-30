using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PQTMUSIC_APP
{
    internal class Class_SongFullData
    {
        public string Key { get; set; }
        public string Title { get; set; }
        public List<Class_Artist> Artists { get; set; }
        public string Duration { get; set; }
        public Image Thumbnail { get; set; }
        public List<StreamUrl> StreamUrls { get; set; }

    }
}
