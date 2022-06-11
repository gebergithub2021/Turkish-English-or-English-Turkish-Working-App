using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Data.Entity
{
    public class TurkishDictionary:IEntity
    {
        public TurkishDictionary()
        {
            CommonProps = new HashSet<CommonProps>();
        }
        public int TurkishWordId { get; set; }
        public string TurkishWord { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CommonProps> CommonProps { get; set; }
    }
}
