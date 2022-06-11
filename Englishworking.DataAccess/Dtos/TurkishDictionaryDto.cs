using AutoMapper;
using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Data.Entity
{
    
    public class TurkishDictionaryDto
    {

        public int TurkishWordId { get; set; }
        public string TurkishWord { get; set; }
        public string Description { get; set; }
    }
}
