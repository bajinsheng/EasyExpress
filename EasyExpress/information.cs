using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExpress
{
    public class information
    {
        public string message { get; set; }
        public string nu { get; set; }
        public bool ischecked { get; set; }
        public string com { get; set; }
        public string status { get; set; }
        public string condition { get; set; }
        public int state { get; set; }
        public List<indexList> data { get; set; }
        public class indexList
        {
            public string time { get; set; }
            public string context { get; set; }
            public string ftime { get; set; }

        }
    }
}
