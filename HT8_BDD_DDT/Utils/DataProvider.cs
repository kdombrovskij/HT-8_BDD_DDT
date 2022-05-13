using HT8_BDD_DDT.DataSource;
using System.Collections.Generic;

namespace HT8_BDD_DDT.Utils
{
    public class DataProvider
    {
        public static IEnumerable<Filter> TestData()
        {

            Filters filters = FilterReader.ReadFiltersFromXML(); 
            System.Console.WriteLine("filters:"+filters.ToString());
            for (int i = 0; i < filters.FiltersList.Count; i++)
            {
                yield return filters.FiltersList[i];
            }
        }

    }
}
