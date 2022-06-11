using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Data.Entity
{
    public class EnglishDictionary:IEntity
    {
        public EnglishDictionary()
        {
            CommonProps = new HashSet<CommonProps>();
        }
        public int EnglishWordId { get; set; }
        public string EnglishWord { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CommonProps> CommonProps { get; set; }
    }
}
