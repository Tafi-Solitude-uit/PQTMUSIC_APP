using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace PQTMUSIC_APP
{
    public class Class_SongFullData
    {
        public string EncodeId { get; set; }
        public string Title { get; set; }
        public List<Class_Artist> Artists { get; set; }
        public string Duration { get; set; }
        public string Thumbnail { get; set; }
        public string StreamUrls { get; set; }
        public bool IsLiked { get; set; }
    }
}
