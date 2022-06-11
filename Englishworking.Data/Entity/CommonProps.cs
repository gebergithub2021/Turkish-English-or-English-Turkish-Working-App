using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Data.Entity
{
    public class CommonProps:IEntity
    {
        public int TurkishId { get; set; }
        public int EnglishId { get; set; }
        public TurkishDictionary TurkishDictionary { get; set; }
        public EnglishDictionary EnglishDictionary { get; set; }
    }
}
