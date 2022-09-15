using System.Collections.Generic;

namespace Latoken.Api.Client.Library.Dto.Rest
{
    public class OHLCChartData
    {
        public List<string> o { get; set; }
        public List<string> c { get; set; }
        public List<string> l { get; set; }
        public List<string> h { get; set; }
        public List<long> t { get; set; }
        public List<string> v { get; set; }
        public string s { get; set; }
    }
}