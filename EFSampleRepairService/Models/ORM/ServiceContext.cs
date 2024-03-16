using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleRepairService.Models.ORM
{
    public class ServiceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-D848M7U\SQLEXPRESS;DatabAse=RepairService;trusted_connection=true;TrustServerCertificate=true");
        }
        public DbSet<Customer> Customers  { get; set; }   
        public DbSet<ServiceRecords> ServiceRecords { get; set; }
        public DbSet<SpareParts> SpareParts { get; set; }

        public DbSet<Personel> Personel { get; set; }
        public DbSet<ServiceStatus> ServiceStatus { get; set; } 
        public DbSet<Invoices> Invoices { get; set; }   
        public DbSet<RepairDetail> RepairDetail { get; set; }

    }
}
