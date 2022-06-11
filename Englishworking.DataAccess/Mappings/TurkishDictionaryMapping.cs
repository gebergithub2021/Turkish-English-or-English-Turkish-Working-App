using AutoMapper;
using Englishworking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.DataAccess.Mappings
{
    public class TurkishDictionaryMapping:Profile
    {
        public TurkishDictionaryMapping()
        {
            CreateMap<TurkishDictionary, TurkishDictionaryDto>().ReverseMap();
            //CreateMap<TurkishDictionaryDto, TurkishDictionary>().ForMember(x=>x.TurkishWordId,x=>x.Ignore());
        }
    }
}
