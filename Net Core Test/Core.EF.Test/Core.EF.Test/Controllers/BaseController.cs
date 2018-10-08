using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace Core.EF.Test.Controllers
{
    public class BaseController : Controller
    {
        //第一种方式初始化数据库上下文
        protected ContextBase _dbContext;
        public BaseController(ContextBase _db)
        {
            _dbContext = _db;
        }
    }
}