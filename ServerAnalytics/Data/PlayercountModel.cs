using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerAnalytics.Data
{
    public class PlayercountModel
    {
        public int id { get; set; }
        public DateTimeOffset timestamp { get; set; }
        public int count { get; set; }
    }
}
