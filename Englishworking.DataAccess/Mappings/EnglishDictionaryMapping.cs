using AutoMapper;
using Englishworking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.DataAccess.Mappings
{
    public class EnglishDictionaryMapping : Profile
    {
        public EnglishDictionaryMapping()
        {
            CreateMap<EnglishDictionary, EnglishDictionaryDto>().ReverseMap();
            //CreateMap<EnglishDictionaryDto, EnglishDictionary>().ReverseMap();
        }
    }
}
