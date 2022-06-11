using Englishworking.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Data.DbMapping
{
    public class TurkishDictionaryMapping : IEntityTypeConfiguration<TurkishDictionary>
    {
        public void Configure(EntityTypeBuilder<TurkishDictionary> builder)
        {
            builder.Property(t=>t.TurkishWordId).UseIdentityColumn(1,1);
            builder.HasKey(t => t.TurkishWordId);
            builder.Property(t => t.TurkishWord).HasColumnName("TurkishWord").IsRequired().HasColumnType("varchar(25)");
            builder.Property(t => t.Description).HasColumnName("Description").IsRequired().HasColumnType("varchar(255)");
            

        }
    }
}
