using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQTMUSIC_APP
{
    public class UserData
    {
        public UserData()
        {
            favSongID = new List<string>();
        }
        public int userid { get; set; }
        public string realname { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string gender { get; set; }
        public int birthday { get; set; }
        public List<string> favSongID { get; set; }
    }
}
