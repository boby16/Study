using System;
using System.Collections.Generic;

namespace Entitys
{
    public class AuditRuleDetail
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 规则外键
        /// </summary>
        public int FK_AuditRule { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public int? FK_Module { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? OrderBy { get; set; }

        /// <summary>
        /// 数据权限（部门、公司、集团）
        /// </summary>
        public int? DataAuthority { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string RoleName { get; set; }

        public AuditRule AuditRule { get; set; }
    }
}
