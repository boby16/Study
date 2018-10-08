using Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Reflection;

namespace DAL
{
    public class ContextBase : DbContext
    {
        //第一种方式初始化数据库上下文
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }
        public ContextBase()
        {

        }

        public DbSet<AuditRule> AuditRules { get; set; }

        public DbSet<AuditRuleDetail> AuditRuleDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //第一种ORM方式
            //modelBuilder.Entity<AuditRule>().ToTable("EHR_AuditRule").HasKey(e => e.ID);
            //modelBuilder.Entity<AuditRuleDetail>().ToTable("EHR_AuditRuleDetail").HasKey(e => e.ID);
            //第二种ORM方式
            //modelBuilder.ApplyConfiguration<AuditRule>(new AuditRuleEntityConfiguration());
            //modelBuilder.ApplyConfiguration<AuditRuleDetail>(new AuditRuleDetailEntityConfiguration());
            //第三种ORM方式
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes().Where(q => q.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type); modelBuilder.ApplyConfiguration(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //第二种方式初始化数据库上下文（未解决）
            //var conn = new ConfigurationBuilder().Build().GetConnectionString("DbConnection");
            //optionsBuilder.UseMySQL(conn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
