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
    public class CommonPropsMapping : IEntityTypeConfiguration<CommonProps>
    {
        public void Configure(EntityTypeBuilder<CommonProps> builder)
        {
            builder.HasKey(cp=>new {cp.TurkishId,cp.EnglishId });
            builder.HasOne(cp => cp.TurkishDictionary).WithMany(t=>t.CommonProps).HasForeignKey(cp=>cp.TurkishId);
            builder.HasOne(cp => cp.EnglishDictionary).WithMany(e => e.CommonProps).HasForeignKey(cp => cp.EnglishId);
        }
    }
}
