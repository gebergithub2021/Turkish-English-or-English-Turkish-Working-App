using AutoMapper;
using Englishworking.Data.DbMapping;
using Englishworking.DataAccess.Abstract;
using Englishworking.DataAccess.Concrete;
using Englishworking.Services.Abstract;
using Englishworking.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.BookUI.Helper
{
    public static class DependencyHelper
    {


        public static IServiceCollection DependencyInjectionService(IServiceCollection serviceCollection)
        {
            return serviceCollection.AddScoped<IChoosingHelper, ChoosingHelper>()
                                       .AddScoped<IEnglishTurkishService, EnglishTurkishService>()
                                       .AddScoped<ITurkishEnglishService, TurkishEnglishService>()
                                       .AddScoped<ICommonPropsRepository, EfCommonPropsRepository>()
                                       .AddScoped<IEnglishDictionaryRepository, EfEnglishDictionaryRepository>()
                                       .AddScoped<ITurkishDictionaryRepository, EfTurkishDictionaryRepository>()
                                       .AddScoped<ICreateDictionary, CreateDictionary>()
                                       .AddScoped<ITransformDto, TransformDto>();
        }

        
    }
}
