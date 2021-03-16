using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class DocumentManagementContext : DbContext
    {
        public DocumentManagementContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<PartyRole> PartyRoles { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PartyRelationship> PartyRelationships { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartyRole>().HasData(
                new PartyRole() { ID = 1, Name = "SuperAdmin", Type = "SA" },
                new PartyRole() { ID = 2, Name = "CompanyAdmin", Type = "CA" },
                new PartyRole() { ID = 3, Name = "DepartmentHead", Type = "DH" },
                new PartyRole() { ID = 4, Name = "Employee", Type = "EE" },
                new PartyRole() { ID = 5, Name = "User", Type = "UR" },
                new PartyRole() { ID = 6, Name = "Department", Type = "DT" },
                new PartyRole() { ID = 7, Name = "Company", Type = "CO" },
                new PartyRole() { ID = 8, Name = "Document", Type = "DO" }
                );
            modelBuilder.Entity<Party>().HasData(
                new Party() { ID = 1, PartyRole_Id = 1 },
                new Party() { ID = 2, PartyRole_Id = 2 },
                new Party() { ID = 3, PartyRole_Id = 3 },
                new Party() { ID = 4, PartyRole_Id = 4 },
                new Party() { ID = 5, PartyRole_Id = 7 },
                new Party() { ID = 6, PartyRole_Id = 6 }
                );
            modelBuilder.Entity<Company>().HasData(
                new Company() { Party_ID = 5, Name = "BA Tech", Address = "E-11", Email = "ba@tech.com", PhoneNo = "080088801" }
                );
            modelBuilder.Entity<Department>().HasData(
                new Department() { Party_ID = 6, Name = "HR", Company_ID = 5 }
                );
            modelBuilder.Entity<User>().HasData(
                new User() { UserName = "sa", Password = "sa", Company_ID = 0, Department_ID = 0, Party_ID = 1 },
                new User() { UserName = "baadmin", Password = "baadmin", Company_ID = 5, Department_ID = 0, Party_ID = 2 },
                new User() { UserName = "bahradmin", Password = "bahradmin", Company_ID = 5, Department_ID = 6, Party_ID = 3 },
                new User() { UserName = "bahremp", Password = "bahremp", Company_ID = 5, Department_ID = 6, Party_ID = 4 }
                );
            modelBuilder.Entity<PartyRelationship>().HasData(
                new PartyRelationship() { ID = 1, FromPartyRole_ID = 1, FromParty_ID = 1, ToPartyRole_ID = 2, ToParty_ID = 2, CreatedByParty_ID = 1, Relation_Type = "C" },
                new PartyRelationship() { ID = 2, FromPartyRole_ID = 2, FromParty_ID = 2, ToPartyRole_ID = 3, ToParty_ID = 3, CreatedByParty_ID = 1, Relation_Type = "C" },
                new PartyRelationship() { ID = 3, FromPartyRole_ID = 3, FromParty_ID = 3, ToPartyRole_ID = 4, ToParty_ID = 4, CreatedByParty_ID = 1, Relation_Type = "C" },
                new PartyRelationship() { ID = 4, FromPartyRole_ID = 1, FromParty_ID = 1, ToPartyRole_ID = 7, ToParty_ID = 5, CreatedByParty_ID = 1, Relation_Type = "C" },
                new PartyRelationship() { ID = 5, FromPartyRole_ID = 2, FromParty_ID = 2, ToPartyRole_ID = 6, ToParty_ID = 6, CreatedByParty_ID = 1, Relation_Type = "C" }
                );
        }
    }
}
