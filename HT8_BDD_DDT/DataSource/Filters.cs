using System;
using System.Collections.Generic;

namespace HT8_BDD_DDT.DataSource
{
    [Serializable]
    public class Filters
    {
        public List<Filter> FiltersList { get; set; }
        public Filters()
        {
            FiltersList = new List<Filter>();
        }
    }
}
