using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitys
{
    public class AuditRuleDetailEntityConfiguration : IEntityTypeConfiguration<AuditRuleDetail>
    {

        public void Configure(EntityTypeBuilder<AuditRuleDetail> builder)
        {
            builder.ToTable<AuditRuleDetail>("EHR_AuditRuleDetail").HasKey(e => e.ID);
        }
    }
}
