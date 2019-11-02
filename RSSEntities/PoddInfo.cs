using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSEntities
{
   public class PoddInfo
    {
        public string Name { get; set; }
        public int NumberOfPods { get; set; }

        public string UpdateInterval { get; set; }
        public string Categories { get; set; }

        public string PodDescription { get; set; }

        public string Url { get; set; }
    }
}
