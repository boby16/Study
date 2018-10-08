using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace Core.EF.Test.Controllers
{
    public class AuditRuleController : BaseController
    {
        //第一种方式初始化数据库上下文
        public AuditRuleController(ContextBase _db) : base(_db)
        {
        }
        public IActionResult Index()
        {
            var module = _dbContext.AuditRules.Where(p => p.ID == 1).FirstOrDefault();
            return View(module);

            //using (var context = new ContextBase())
            //{
            //    var module = context.AuditRules.Where(p => p.ID == 1).ToList();
            //    return View(module);
            //}
        }
    }
}