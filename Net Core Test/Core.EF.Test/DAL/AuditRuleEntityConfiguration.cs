using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitys
{
    public class AuditRuleEntityConfiguration: IEntityTypeConfiguration<AuditRule>
    {

        public void Configure(EntityTypeBuilder<AuditRule> builder)
        {
            builder.ToTable<AuditRule>("EHR_AuditRule").HasKey(e => e.ID);
            builder.HasMany<AuditRuleDetail>(p => p.AuditRuleDetails).WithOne(p => p.AuditRule).HasForeignKey(p => p.FK_AuditRule);
        }
    }
}
