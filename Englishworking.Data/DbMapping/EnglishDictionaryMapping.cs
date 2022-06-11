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
    public class EnglishDictionaryMapping : IEntityTypeConfiguration<EnglishDictionary>
    {
        public void Configure(EntityTypeBuilder<EnglishDictionary> builder)
        {
            builder.Property(e => e.EnglishWordId).UseIdentityColumn(1,1);
            builder.HasKey(e => e.EnglishWordId);
            builder.Property(e => e.EnglishWord).HasColumnName("EnglishWord").IsRequired().HasColumnType("varchar(25)");
            builder.Property(e => e.Description).HasColumnName("Description").IsRequired().HasColumnType("varchar(255)");
        }
    }
}
