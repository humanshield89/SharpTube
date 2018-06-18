using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YT_scraper.Data;

namespace YT_scraper.Workers
{
    class Scrape
    {
        public MatchCollection scrape(ScrapeCriteria scrapeCriteria)
        {
           return Regex.Matches(scrapeCriteria.Data , scrapeCriteria.Regex ,scrapeCriteria.regexOptions);
            
        }
    }
}
