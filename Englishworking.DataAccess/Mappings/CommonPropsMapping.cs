using AutoMapper;
using Englishworking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.DataAccess.Mappings
{
    public class CommonPropsMapping:Profile
    {
        public CommonPropsMapping()
        {
            CreateMap<CommonProps, CommonPropsDto>().ReverseMap();
            //CreateMap<CommonPropsDto, CommonProps>();
           
        }
    }
}
