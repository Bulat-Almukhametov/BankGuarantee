using BankGuarantee.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Desktop.DbIntegration
{
    // класс для работы с БД, содержит все таблицы для получения данных
    class BankGuaranteeContext : DbContext
    {
        public BankGuaranteeContext()
            :base("DefaultConnection")
        { }
        public DbSet<Guarantee> Guarantees { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Credential> Credentials { get; set; }
    }
}
