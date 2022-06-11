using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration.Annotations;

namespace Englishworking.Data.Entity
{
    
    public class EnglishDictionaryDto
    {

        public int EnglishWordId { get; set; }
        public string EnglishWord { get; set; }
        public string Description { get; set; }
    }
}
