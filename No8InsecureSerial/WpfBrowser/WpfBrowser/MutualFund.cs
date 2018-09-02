using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBrowser
{
    public abstract class Share
    {
        public string Name { get; set; }
    }

    public class RecommendedShare : Share
    {
        public int Stars { get; set; }
    }

    public class MutualFund
    {
        public string FullName { get; set; }
        public IList<Share> Portfolio { get; set; }
    }
}
