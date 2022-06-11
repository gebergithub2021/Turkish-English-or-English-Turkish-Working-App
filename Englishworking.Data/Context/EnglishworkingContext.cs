using Englishworking.Data.DbMapping;
using Englishworking.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Data.Context
{
    public class EnglishworkingContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS1; database= Englishworking; trusted_connection=true;");
        }
        DbSet<TurkishDictionary> TurkishDictionary { get; set; }
        DbSet<EnglishDictionary> EnglishDictionary { get; set; }
        DbSet<CommonProps> CommonProps { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TurkishDictionaryMapping());
            modelBuilder.ApplyConfiguration(new EnglishDictionaryMapping());
            modelBuilder.ApplyConfiguration(new CommonPropsMapping());
        }
    }
}
