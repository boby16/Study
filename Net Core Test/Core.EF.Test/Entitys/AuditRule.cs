using System;
using System.Collections.Generic;

namespace Entitys
{
    public class AuditRule
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 调整类型（架构、调岗/调薪）
        /// </summary>
        public int? Type { get; set; }

        /// <summary>
        /// 公司类型（分公司、集团）
        /// </summary>
        public int? CompanyType { get; set; }

        public List<AuditRuleDetail> AuditRuleDetails { get; set; }
    }
    
}
