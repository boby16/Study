using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    class AuditRuleBLL
    {
        public static AuditRule GetDate()
        {
            using (var context = new ContextBase())
            {
                return context.AuditRules.Where(p => p.ID == 1).FirstOrDefault();
            }
        }
    }
}
