using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YT_scraper.Data
{
    class ScrapeCriteria
    {
        public string Data { get; }
        public string Regex { get; }
        public RegexOptions regexOptions = RegexOptions.ExplicitCapture;

        public ScrapeCriteria(string DataArg, string RegexArg) 
        {
            Data = DataArg;
            Regex = RegexArg;
        }
    }
}
