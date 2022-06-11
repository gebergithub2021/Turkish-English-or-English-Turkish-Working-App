using AutoMapper;
using Englishworking.BookUI.Helper;
using Englishworking.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Englishworking.BookUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var service = new ServiceCollection();
            DependencyHelper.DependencyInjectionService(service);
            AutoMapperInjection.MapperInjection(service);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            service.AddScoped<Form1>();
            service.AddScoped<TurkishDictionaryDto>();
            service.AddScoped<EnglishDictionaryDto>();
            service.AddScoped<CommonPropsDto>();
            using (ServiceProvider serviceProvider = service.BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService<Form1>());
            }   
        }
    }
}
