using AutoMapper;
using Englishworking.DataAccess.Mappings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.BookUI.Helper
{
    public static class AutoMapperInjection
    {
        public static IServiceCollection MapperInjection(this IServiceCollection service)
        {


            return service.AddAutoMapper(typeof(CommonPropsMapping))
                .AddAutoMapper(typeof(EnglishDictionaryMapping)).AddAutoMapper(typeof(TurkishDictionaryMapping));
        }

    }
}
