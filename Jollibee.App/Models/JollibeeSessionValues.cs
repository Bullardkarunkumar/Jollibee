using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jollibee.App.Models
{
    public class JollibeeSessionValues
    {
        public string SessionName { get; set; }
        public static Dictionary<int, ActiveSessions> ActiveTabIndex = new Dictionary<int, ActiveSessions>();
    }
    public class ActiveSessions
    {
        public bool IsActive { get; set; }
        public string HeaderValue { get; set; }
        public bool IsTabInstance { get; set; }
        public string ImagePath { get; set; }

    }
}
