using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Models
{
    public partial class basket
    {
        public int id { get; set; }
        public int buyerid { get; set; }
        public int goodid { get; set; }
        public virtual buyer buyer { get; set; }
        public virtual good good { get; set; }
    }
}
